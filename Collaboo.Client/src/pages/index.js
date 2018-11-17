import React from 'react';
import PropTypes from 'prop-types';
import Grid from '@material-ui/core/Grid';
import { withStyles } from '@material-ui/core/styles';
import withRoot from '../withRoot';
import Navbar from '../components/navbar';
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';

const styles = theme => ({
  root: {
    flexGrow: 1,
    width: '100%'
  },
});

class Index extends React.Component {
  state = {
    open: false,
  };

  handleClose = () => {
    this.setState({
      open: false,
    });
  };

  handleClick = () => {
    this.setState({
      open: true,
    });
  };

  render() {
    const { classes } = this.props;
    
    const Index = () => <h2>Home</h2>;
    const About = () => <h2>About</h2>;
    const Users = () => <h2>Users</h2>;

    return (
      <div className={classes.root}>
        <Navbar />
        <br />
        <Grid container>
        <Grid item md={3}>
          menu
        </Grid>
          
            <Router>
            <Grid item md={9}>
              <Route path="/" exact component={Index} />
              <Route path="/about/" component={About} />
              <Route path="/users/" component={Users} />
              </Grid>
            </Router>
        </Grid>
        
      </div>
    );
  }
}

Index.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withRoot(withStyles(styles)(Index));