import React from 'react';
import Avatar from '@material-ui/core/Avatar';
import classNames from 'classnames';
import { withStyles } from '@material-ui/core/styles';

const styles = theme => ({
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
            <div>
                <Avatar
                alt="Collaboo"
                src="https://via.placeholder.com/150"
                className={classNames(classes.avatar, classes.bigAvatar)}
            />
            </div>
        );
    }
}

export default withStyles(styles)(Sidebar);  