# api-node.js
This is the Node API version of the voting application

## Contract
The API exposes four operations under the localhost/api/votes url, those are:

- **/Elections (GET) : returns all elections;
- **/Elections/{id} (GET) : returns a specified election by the invoqued id ;
- **/Elections/{id} (PUT) : creates an election (idempotent) - election should be created without votes;
- **/Elections/{id}/Votes (POST) : sends a vote.

## Content
The JSON basic form is the following :
> {
>   "id" : "BDE",
>   'votes': [
>      {
>       'choix': 1,
>        'prenom': 'Adel'
>      },
 >     {
 >       'choix': 2,
 >       'prenom': 'Quentin'
 >     },
 >     {
 >       'choix': 2,
 >       'prenom': 'Fadwa'
 >     }]
> }

## Launch the api with docker:
after have installed docker on your computer,
You should do the command lines in administrator while being in the directory that contains the dockerfile:
> docker build -t test . 

> docker run -d -p 80:5004 --name Test test 

> docker logs Test

> docker rm -fv `docker ps -aq` 

## Explanation docker command lines
- The first command allows to build the image test (do not forget the .)
- The second allows to run the api over the 5004 port with a container named 'Test'
- In case it doesn't work, you can debug the api by doing the third command line and see what are the errors
- The last command line allows to remove all the images already built.