const apiUrl = 'https://collabooappwebapi20181117101038.azurewebsites.net/api/'

export const createProject = function(project) {
    const requestOptions = {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(project)
    };
    console.log(JSON.stringify(project))
    let result = fetch(apiUrl + 'users/3/projects', requestOptions)
    .then((response) => {
        return response;
    });

    console.log(result);

    return result;

}