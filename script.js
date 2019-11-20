document.querySelector('button#sendRequest').addEventListener('click', async function() {
    const cityInput = document.querySelector('input#city');
    const cityName = cityInput.value;

    const weatherData = await getWeatherDataJson(cityName);
    const outputSpan = document.querySelector('span#result');
    outputSpan.text = weatherData;
});

async function getWeatherDataJson(cityName) {
    const response = await fetch(`https://localhost:44382/api/weather?cityName=${cityName}`,
        {
            method: 'GET',
            dataType: 'jsonp'
        });

    return await response.json();
}