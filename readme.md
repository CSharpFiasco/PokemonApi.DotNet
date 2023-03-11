# Pokemon API

This API is meant for learning purposes

All data comes from the [pokeAPI](https://github.com/PokeAPI/pokeapi)

The API uses .NET 7, odata, entity framework, swagger/swashbuckle, with xunit as the testing framework

The UI uses angular, with jasmine as the testing framework

Run both at the same time by selecting the API and the UI as the (multiple) startup projects

## Docker

### Build command
    docker build --file ./api.dockerfile --tag pokemon-api . 

### Run command
    docker run -it -p 5000:80 --name=pokemon-api pokemon-api