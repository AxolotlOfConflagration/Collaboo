import React from 'react';
import TextField from '@material-ui/core/TextField';
import { connect } from 'react-redux';
import Typography from '@material-ui/core/Typography';
import Button from '@material-ui/core/Button';
import { createProject } from '../services';
import Checkbox from '@material-ui/core/Checkbox';
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
        id: 1,
        name: 'C#'
    },
    {
        id: 2,
        name: 'React'
    }
]

class CreateProject extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            projectName: "",
            description: "",
            requirements: [],
            gitHubRepoUrl: ""
        }
        // reset login status
        this.props.dispatch(login());
    }
    
    handleChange = name => event => {
        if(name == 'requirements'){
            let reqs = this.state.requirements;
            let skill = event.target.value;

            let levelElement = document.getElementById('requirementsLevel#' + skill)
            console.log(levelElement);

            if(event.target.checked){
                reqs.push({skillId: skill, rating: levelElement.value});
            } else {
                reqs.forEach((req, index) => {
                    if(req.skillId = skill) reqs.splice(index, 1);
                })
            }
            this.setState({
            requirements: reqs,
            });
            console.log(reqs);
        } else if(name == 'requirementsLevel') {
            let reqs = this.state.requirements;
            let skillLevel = event.target.value;
            let skillId = event.target.dataset.id;

            reqs.forEach((req, index) => {
                if(req.skillId == skillId) reqs[index].rating = skillLevel;
            })

            this.setState({
            requirements: reqs,
            });
            console.log(reqs)
        } else {
            this.setState({
            [name]: event.target.value,
            });
        }
    };
    
    handleSubmit = event => {
        event.preventDefault();
        createProject(this.state);
    }

    render() {
        const { classes } = this.props;
        return (
            <div className="CreateProject">
                <Typography component="h2" variant="h2" gutterBottom>
                Create new project
                </Typography>
                <p>Only thing you need is an idea. Idea can spark something big. We can help you find people, that share your values and meet your needs. It's easier to do something big together!</p>
                <form noValidate autoComplete="off" onSubmit={this.handleSubmit}>
                <TextField
                    id="project-name"
                    label="Project Name"
                    value={this.state.projectName}
                    onChange={this.handleChange('projectName')}
                    margin="normal"
                    fullWidth
                    />
                <TextField
                    id="github-repo-url"
                    label="GitHub repository URL (optional)"
                    value={this.state.gitHubRepoUrl}
                    onChange={this.handleChange('gitHubRepoUrl')}
                    margin="normal"
                    fullWidth
                    />
                <TextField
                    id="project-description"
                    label="Project Description"
                    value={this.state.description}
                    onChange={this.handleChange('description')}
                    margin="normal"
                    multiline
                    rowsMax="4"
                    fullWidth
                    />
                    <br />
                    <br />  

                    <p>Select skills that users should have to be able to participate in this project</p>
                    <div className="skills-selector">
                        {skills.map(skill => (
                            <div>
                            {skill.name}<Checkbox onChange={this.handleChange('requirements')} name={"skill#" + skill.id} value={skill.id} />
                            <select
                                onChange={this.handleChange('requirementsLevel')}
                                data-id={skill.id}
                                id={"requirementsLevel#" + skill.id}
                            >
                                <option value="1">1</option>
                                <option value="2">2</option>
                                <option value="3">3</option>
                                <option value="4">4</option>
                                <option value="5">5</option>
                            </select>
                            </div>
                        ))}
                    </div>
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