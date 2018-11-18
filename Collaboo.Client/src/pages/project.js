import React from 'react';
import TextField from '@material-ui/core/TextField';
import { connect } from 'react-redux';
import Button from '@material-ui/core/Button';
import { inviteUserToProject, getProjectUsers, getProjectCommits } from '../services';
const styles = theme => ({
    root: {
        
    },
    button: {
        margin: "40px auto"
    }
  });


class Project extends React.Component {
    constructor(props) {
        super(props);
        
        this.state = {
            iviteUserWithUserName: null,
            users: null,
            commits: null
        }
    }



    getProjectUsers(){
        let projectId = this.props.match.params.id;
        getProjectUsers(projectId).then(data => {
            this.setState({users: data});
        })
        }

    getProjectCommits(){
        let projectId = this.props.match.params.id;
        getProjectCommits(projectId).then(data => {
            this.setState({commits: data});
        })
    }

  componentDidMount(){
    this.getProjectUsers();
  }


    inviteUser = event => {
        let projectId = this.props.match.params.id;
        let userName = event.target.value;
        inviteUserToProject(userName, projectId)
    }
    
    render() {
        const { classes } = this.props;
        const { users, commits } = this.state;
    
        return (
            <div className="Project">
                <h1>Project name</h1>
                <p>Project description Project description Project description Project description Project description </p>
                <form noValidate autoComplete="off" onSubmit={this.inviteUser}>
                <TextField
                    id="user-name"
                    label="Invite user to team"
                    margin="normal"
                    fullWidth
                    />
                    <Button type="submit" variant="contained" size="medium" color="secondary">
                    Invite
                    </Button>
                    <hr />
                    <h4>Users belonging to project:</h4>
                    {users &&
                        <div>{users.map((user) => 
                            <div>
                            {user.login}
                            <br />
                            </div>
                        )}
                        </div>
                        }
                        <hr />
                    <h4>Last changes in this project:</h4>
                    {users &&
                        <div>{users.map((user) => 
                            <div>
                            {user.login}
                            <br />
                            </div>
                        )}
                        </div>
                        }
                </form>
            </div>
        );
    }
}

function mapStateToProps(state) {
    return state;
}

const connectedProject = connect(mapStateToProps)(Project);
export { connectedProject as Project }; 