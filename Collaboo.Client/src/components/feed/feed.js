import React from 'react';
import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import CardDefault from './card-default';
import { getFeed } from '../../services/';
import Typography from '@material-ui/core/Typography';

const styles = theme => ({
  root: {
    width: '100%',
  },
  card: {
    marginBottom: "10px"
  },
  center: {
    textAlign: 'center',
    margin: '15px 0',
    color: '#777'
  }
});

class Feed extends React.Component {
  state = {
    projects: null
  }

  getProjects(){
    this.setState({projects: getFeed()});
    // getFeed().then(data => {
    //   console.log(data)
    //   this.setState({projects: data});
    // })
  }

  componentDidMount(){
    this.getProjects();
  }

  render() {
    const { classes } = this.props;
    const { projects } = this.state;
    

    return (
      <div className={classes.root}>
        <Typography component="h3" variant="h3" gutterBottom>
        Your feed
        </Typography>
        
        <Typography component="p" variant="p" gutterBottom>
          This is main the most important place in Collaboo. You can see here <strong>recommended projects, recent activities in repos, updates from projects and new announcements</strong>.
        </Typography>
        <br /><hr /><br />
        {projects &&
          <div>{projects.map((project, index) => 
            <div>
          <CardDefault 
            text={project.description}
            id={project.id}
            heading={project.projectName}
            className={classes.card} />
            <br />
            </div>
        )}
          </div>
        }
        <Typography component="p" variant="p" gutterBottom className={classes.center}>
          This is the end of your feed :)
        </Typography>
      </div>
    );
  }
}

Feed.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Feed);