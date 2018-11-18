const apiUrl = 'http://localhost:5000/'

export const createProject = function(project) {
    let user = JSON.parse(localStorage.getItem('user'));
    const requestOptions = {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(project)
    };
    fetch(apiUrl + 'users/' + user.id + '/projects', requestOptions)
    .then((response) => {
        return response;
    });
}
export const login = function() {
    const requestOptions = {
        method: 'GET'
    };
    fetch(apiUrl + 'login', requestOptions)
    .then((response) => {
        return response;
    });

}

export const getUser = function(id) {
    return fetch(apiUrl + 'users/' + id)
    .then(handleResponse)
    .then(data => {
        return data;
    })

}

export const getFeed = function(id) {
    let user = JSON.parse(localStorage.getItem('user'));
    return [
        {
            projectName: "Test 1",
            id: 1,
            description: "Testowy opis"
        },
        {
            projectName: "Test 2",
            id: 2,
            description: "Testowy opis"
        },
        {
            projectName: "Test 3",
            id: 3,
            description: "Testowy opis"
        },
        {
            projectName: "Test 4",
            id: 4,
            description: "Testowy opis"
        },
    ]
    // return fetch(apiUrl + 'users/' + user.id + '/feed')
    // .then(handleResponse)
    // .then(data => {
    //     return data;
    // })

}

export const getProjects = function() {

    let user = JSON.parse(localStorage.getItem('user'));
    console.log("User: ", user)
    return fetch(apiUrl + 'users/' + user.id + '/projects')
    .then(handleResponse)
    .then(data => {
    return data;
    })

}

export const getProjectUsers = function(projectId) {

    return fetch(apiUrl + 'projects/' + projectId + '/users')
    .then(handleResponse)
    .then(data => {
    return data;
    })

}


export const getProjectCommits = function(projectId) {

    return fetch(apiUrl + 'projects/' + projectId + '/commits')
    .then(handleResponse)
    .then(data => {
    return data;
    })

}

export const inviteUserToProject = function(userName, projectId) {
    let user = JSON.parse(localStorage.getItem('user'));
    const requestOptions = {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({userName})
    };
    fetch(apiUrl + 'projects/' + projectId, requestOptions)
    .then((response) => {
        return response;
    });
}

function handleResponse(response) {
    return new Promise((resolve, reject) => {
        if (response.ok) {
            // return json if it was returned in the response
            var contentType = response.headers.get("content-type");
            if (contentType && contentType.includes("application/json")) {
                response.json().then(json => resolve(json));
            } else {
                resolve();
            }
        } else {
            // return error message from response body
            reject(response.statusText, response.status);
        }
    });
}