var loading_screen_phrases = ["Red apple juices fermenting...",
    "Sweet sap draining from maple tree...",
    "Fresh lemons being squeezed...",
    "Sliced ginger root soaking in pitcher...",
    "A cracked cinnamon dusting for the final touch..."
];

function getLoadingScreenPhrase() {
    const randomIndex = Math.floor(Math.random() * loading_screen_phrases.length);

    return loading_screen_phrases[randomIndex];
}

document.getElementById("loading").innerHTML = getLoadingScreenPhrase();