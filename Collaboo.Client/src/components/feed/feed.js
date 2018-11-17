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
        <CardDefault 
          text="Heat oil in a (14- to 16-inch) paella pan or a large, deep skillet over medium-high
          heat. Add chicken, shrimp and chorizo, and cook, stirring occasionally until lightly
          browned, 6 to 8 minutes. Transfer shrimp to a large plate and set aside, leaving
          chicken and chorizo in the pan. Add pimentón, bay leaves, garlic, tomatoes, onion,
          salt and pepper, and cook, stirring often until thickened and fragrant, about 10
          minutes. Add saffron broth and remaining 4 1/2 cups chicken broth; bring to a boil."
          heading="Nazwa proponowego projektu"/>
      </div>
    );
  }
}

Feed.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(Feed);