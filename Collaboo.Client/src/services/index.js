const apiUrl = 'https://collabooappwebapi20181117101038.azurewebsites.net/api/'




export const createProject = function(project) {
    const requestOptions = {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(project)
    };
    fetch(apiUrl + 'users/3/projects', requestOptions)
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

export const getProjects = function() {

    let user = JSON.parse(localStorage.getItem('user'));
    console.log("User: ", user)
    return fetch(apiUrl + 'users/' + user.id + '/projects')
    .then(handleResponse)
    .then(data => {
    return data;
    })

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