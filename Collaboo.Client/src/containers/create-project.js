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
import { Link } from 'react-router-dom'

import { login } from '../actions/index';
const styles = theme => ({
    root: {
      display: 'flex',
      flexWrap: 'wrap',
    },
    formControl: {
      margin: theme.spacing.unit,
      minWidth: 120,
      maxWidth: 300,
    },
    chips: {
      display: 'flex',
      flexWrap: 'wrap',
    },
    chip: {
      margin: theme.spacing.unit / 4,
    },
    noLabel: {
      marginTop: theme.spacing.unit * 3,
    },
  });

const skills = [
    {
        id: 12,
        name: 'C#'
    },
    {
        id: 8,
        name: 'Rest API'
    }
]

class CreateProject extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            name: "",
            description: "",
            requirements: []
        }
        // reset login status
        this.props.dispatch(login());
    }
    
    handleChange = name => event => {
        this.setState({
        [name]: event.target.value,
        });
    };

    render() {
        const { classes } = this.props;
        return (
            <div className="CreateProject">
                <Typography component="h2" variant="h2" gutterBottom>
                Create new project
                </Typography>
                <p>Only thing you need I an idea. Ideas can spark something big. We help you find people, that share your values and meet your needs. It's easier to do something big together!</p>
                <form noValidate autoComplete="off">
                <TextField
                    id="project-name"
                    label="Project Name"
                    value={this.state.name}
                    onChange={this.handleChange('name')}
                    margin="normal"
                    fullWidth
                    />
                <TextField
                    id="project-description"
                    label="Project Descriptiom"
                    value={this.state.name}
                    onChange={this.handleChange('name')}
                    margin="normal"
                    multiline
                    rowsMax="4"
                    fullWidth
                    />
                    <br />
                    <br />  

                    <p>Select skills that users should have to be able to participate in this project</p>
                    <FormControl fullWidth>
                      <InputLabel htmlFor="project-requirements">Required skills</InputLabel>
                    <Select
                        multiple
                        id="project-requirements"
                        value={this.state.requirements}
                        onChange={this.handleChange('requirements')}
                        input={<Input id="select-multiple-chip" />}
                        fullWidth
                        margin="normal"
                        renderValue={selected => (
                        <div>
                            {selected.map(value => (
                            <Chip key={value} label={value} />
                            ))}
                        </div>
                        )}
                    >
                        {skills.map(skill => (
                        <MenuItem key={skill.id} value={skill.name}>
                            {skill.name}
                        </MenuItem>
                        ))}
                    </Select>
                    </FormControl>
                    <br />
                    <br /> 
                    <br />
                    <br /> 
                    <Button type="submit" variant="contained" size="medium" color="secondary">
                    Send
                    </Button>
                </form>
            </div>
        );
    }
}

function mapStateToProps(state) {
    return state;
}

const connectedCreateProject = connect(mapStateToProps)(CreateProject);
export { connectedCreateProject as CreateProject }; 