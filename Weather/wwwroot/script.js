document.querySelector('button#sendRequest').addEventListener('click', async function() {
    const cityInput = document.querySelector('input#city');
    const cityName = cityInput.value;

    const weatherData = await getWeatherDataJson(cityName);
    if (weatherData === null) {
        alert("There is no such city");
        return;
    }

    const tempElem = document.querySelector('#temp');
    tempElem.innerText = weatherData.main.temp;

    const nameElem = document.querySelector('#name');
    nameElem.innerText = weatherData.name;

    const speedElem = document.querySelector('#speed');
    speedElem.innerText = weatherData.wind.speed;

    const degElem = document.querySelector('#deg')
    degElem.innerText = weatherData.wind.deg;

    const lonElem = document.querySelector('#lon');
    lonElem.innerText = weatherData.coord.lon;

    const latElem = document.querySelector('#lat');
    latElem.innerText = weatherData.coord.lat;
});

async function getWeatherDataJson(cityName) {
    const response = await fetch(`https://localhost:44382/api/weather?cityName=${cityName}`,
        {
            method: 'GET'
        });
    if (response.status === 400) {
        return null;
    }
    return await response.json();
}