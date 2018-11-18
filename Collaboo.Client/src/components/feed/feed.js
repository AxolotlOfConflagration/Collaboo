import React from 'react';
import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import CardDefault from './card-default';
import { getProjects } from '../../services/'

const styles = theme => ({
  root: {
    width: '100%',
  },
  card: {
    marginBottom: "10px"
  }
});

class Feed extends React.Component {
  state = {
    projects: null
  }

  getProjects(){
    getProjects().then(data => {
      console.log(data)
      this.setState({projects: data});
    })
  }

  componentDidMount(){
    this.getProjects();
  }

  render() {
    const { classes } = this.props;
    const { projects } = this.state;
    

    return (
      <div className={classes.root}>
        {projects &&
          <div>{projects.map((project) => 
            <div>
          <CardDefault 
            text={project.description}s
            heading={project.projectName}
            className={classes.card} />
            <br />
            </div>
        )}
          </div>
        }
      </div>
    );
  }
}

Feed.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Feed);