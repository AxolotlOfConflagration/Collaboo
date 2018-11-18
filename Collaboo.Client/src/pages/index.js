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
import { Login } from './login';
import { Provider } from 'react-redux';
import { store } from '../reducers/store';
import { getUser } from '../services';

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

  componentDidMount(){
    let user = getUser();
    if(!user) console.log(user);
  }

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
  
  findGetParameter(parameterName) {
    var result = null,
        tmp = [];
    window.location.search
        .substr(1)
        .split("&")
        .forEach(function (item) {
          tmp = item.split("=");
          if (tmp[0] === parameterName) result = decodeURIComponent(tmp[1]);
        });
    return result;
  }

  render() {
    const { classes } = this.props;
    let appState = store.getState();
    
    let loggedIn = localStorage.getItem('user');
    if(window.location.href.indexOf("authorize") > -1) {
      let userId = this.findGetParameter('id');
      let user = getUser(userId).then(data => {
        localStorage.setItem('user', JSON.stringify(data));
      });
    }
    


    const Users = () => <h2>Users</h2>;

    return (
      <Provider store={store}>
      <Router>
        <div className={classes.root}>
        <Navbar />
        <br />
        <Grid container spacing={24} className={classes.container}>
            <Grid item md={3}> 
            {loggedIn &&
              <Sidebar />
            }
            </Grid>
            <Grid item md={6}>
              <Route path="/" exact component={Feed} />
              <Route path="/new-project" component={CreateProject} />
              <Route path="/login" component={Login} />
            </Grid>
            <Grid item md={3}> 
            {loggedIn &&
              <p>Users activity or sth</p>
            }
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