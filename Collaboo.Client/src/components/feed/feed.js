import React from 'react';
import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import CardDefault from './card-default';

const styles = theme => ({
  root: {
    width: '100%',
  },
});

class Feed extends React.Component {

  render() {
    const { classes } = this.props;
    return (
      <div className={classes.root}>
        <CardDefault />
      </div>
    );
  }
}

Feed.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Feed);