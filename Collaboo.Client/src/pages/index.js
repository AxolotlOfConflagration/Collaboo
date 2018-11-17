import React from 'react';
import PropTypes from 'prop-types';
import Grid from '@material-ui/core/Grid';
import { withStyles } from '@material-ui/core/styles';
import withRoot from '../withRoot';
import Navbar from '../components/navbar';
import Feed from '../components/feed/feed';
import Sidebar from '../components/sidebar';
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';
import { CreateProject } from './create-project';
import { Provider } from 'react-redux';
import { store } from '../reducers/store';
import classNames from 'classnames';

const styles = theme => ({
  root: {
    flexGrow: 1,
    paddingTop: "64px"
  },
  container: {
    width: '95%',
    maxWidth: "1200px",
    margin: "auto"
  },
  sidebar: {
    textAlign: "center"
  },
  avatar: {
    margin: "auto",
  },
  bigAvatar: {
    width: 120,
    height: 120,
    margin: "auto",
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
    
    const Users = () => <h2>Users</h2>;

    return (
      <Provider store={store}>
      <Router>
        <div className={classes.root}>
        <Navbar />
        <br />
        <Grid container spacing={24} className={classes.container}>
            <Grid item md={3}> 
              <Sidebar />
            </Grid>
            <Grid item md={6}>
              <Route path="/" exact component={Feed} />
              <Route path="/new-project" component={CreateProject} />
              <Route path="/users/" component={Users} />
            </Grid>
            <Grid item md={3}> 
              Users activity or sth
            </Grid>
        </Grid>
        
        </div>
      </Router>
      </Provider>
    );
  }
}

Index.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withRoot(withStyles(styles)(Index));