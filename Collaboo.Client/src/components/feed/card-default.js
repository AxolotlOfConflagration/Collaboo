import React from 'react';
import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import classnames from 'classnames';
import Card from '@material-ui/core/Card';
import CardMedia from '@material-ui/core/CardMedia';
import CardContent from '@material-ui/core/CardContent';
import CardActions from '@material-ui/core/CardActions';
import Button from '@material-ui/core/Button';
import IconButton from '@material-ui/core/IconButton';
import Typography from '@material-ui/core/Typography';
import red from '@material-ui/core/colors/red';
import FavoriteIcon from '@material-ui/icons/Favorite';
import ShareIcon from '@material-ui/icons/Share';
import { Link } from 'react-router-dom';

const styles = theme => ({
  card: {
    width: "100%"
  },
  media: {
    height: 0,
    paddingTop: '56.25%', // 16:9
  },
  actions: {
    display: 'flex',
  },
  expand: {
    transform: 'rotate(0deg)',
    transition: theme.transitions.create('transform', {
      duration: theme.transitions.duration.shortest,
    }),
    marginLeft: 'auto',
    [theme.breakpoints.up('sm')]: {
      marginRight: -8,
    },
  },
  expandOpen: {
    transform: 'rotate(180deg)',
  },
  avatar: {
    backgroundColor: red[500],
  },
});

class CardDefault extends React.Component {
  state = { expanded: false };

  handleExpandClick = () => {
    this.setState(state => ({ expanded: !state.expanded }));
  };

  render() {
    const { classes, heading, text, id } = this.props;

    return (
      <Card className={classes.card}>
        
        <h5 className="proposition-tag">
            #RECOMMENDED_PROJECT
          </h5>
        <CardMedia
          className={classes.media}
          image="/placeholder600x300.jpg"
        />
        <CardContent>
          <Typography component="h5" variant="h5" gutterBottom>
            {heading}
          </Typography>
          <Typography component="p">
            {text}
          </Typography>
          <br />
          <Button variant="contained" color="secondary" className={classes.button}>
            Wanna collab!
          </Button>
          <Button href={"/project/" + id} className={classes.button}>
          Show project
          </Button>
        </CardContent>
        <CardActions className={classes.actions} disableActionSpacing>
          <IconButton aria-label="Add to favorites">
            <FavoriteIcon />
          </IconButton>
          <IconButton aria-label="Share">
            <ShareIcon />
          </IconButton>
          <IconButton
            className={classnames(classes.expand, {
              [classes.expandOpen]: this.state.expanded,
            })}
            onClick={this.handleExpandClick}
            aria-expanded={this.state.expanded}
            aria-label="Show more"
          >
          </IconButton>
        </CardActions>
      </Card>
    );
  }
}

CardDefault.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(CardDefault);