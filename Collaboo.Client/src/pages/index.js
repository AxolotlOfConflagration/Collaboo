import React from 'react';
import PropTypes from 'prop-types';
import Grid from '@material-ui/core/Grid';
import { withStyles } from '@material-ui/core/styles';
import withRoot from '../withRoot';
import Navbar from '../components/navbar';

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
    
    return (
      <div className={classes.root}>
        <Navbar />
        <br />
        <Grid container>
        <Grid item md={3}>
          menu
        </Grid>
        <Grid item md={9}>
          content
        </Grid>
        
      </Grid>
      </div>
    );
  }
}

Index.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withRoot(withStyles(styles)(Index));