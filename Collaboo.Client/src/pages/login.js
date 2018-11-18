import React from 'react';
import TextField from '@material-ui/core/TextField';
import { connect } from 'react-redux';
import Typography from '@material-ui/core/Typography';
import Select from '@material-ui/core/Select';
import Input from '@material-ui/core/Input';
import Chip from '@material-ui/core/Chip';
import MenuItem from '@material-ui/core/MenuItem';
import InputLabel from '@material-ui/core/InputLabel';
import FormControl from '@material-ui/core/FormControl';
import Button from '@material-ui/core/Button';
import { login } from '../services';
import Checkbox from '@material-ui/core/Checkbox';
const styles = theme => ({
    root: {
        
    },
    button: {
        margin: "40px auto"
    }
  });


class Login extends React.Component {
    constructor(props) {
        super(props);
        
    }

    login = () => {
        window.location.href = 'https://collabooappwebapi20181117101038.azurewebsites.net/api/login';
    }
    
    render() {
        const { classes } = this.props;
        return (
            <div className="Login">
                <Button  variant="contained" size="medium" color="secondary" onClick={this.login}>
                Login
                </Button>
            </div>
        );
    }
}

function mapStateToProps(state) {
    return state;
}

const connectedLogin = connect(mapStateToProps)(Login);
export { connectedLogin as Login }; 