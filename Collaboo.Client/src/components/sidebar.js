import React from 'react';
import Avatar from '@material-ui/core/Avatar';
import Button from '@material-ui/core/Button';
import classNames from 'classnames';
import { withStyles } from '@material-ui/core/styles';

const styles = theme => ({
    root: {
        textAlign: "center",
        position: "sticky",
        top: "95px"
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

class Sidebar extends React.Component {
    render(){
        const { classes } = this.props;
        return(
            <div className={classes.root}>
                <Avatar
                alt="Collaboo"
                src="/rat-square.jpg"
                className={classNames(classes.avatar, classes.bigAvatar)}
            />
            <br />
            <strong>User Name</strong>
            <br />
            <br />

            <hr />
            <div style={{textAlign: "left"}}>
            
            <Button href="#">
                Your feed
            </Button>
            
            <Button href="#">
                Recommended projects
            </Button>
            
            <Button href="#">
                Find coding buddy
            </Button>
            
            <Button href="#">
                Your projects
            </Button>
            
            <Button href="#">
                Hot projects
            </Button>
            </div>

            </div>
        );
    }
}

export default withStyles(styles)(Sidebar);  