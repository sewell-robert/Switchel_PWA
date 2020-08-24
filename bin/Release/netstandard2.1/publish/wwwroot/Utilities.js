function initializeCounterComponent() {
        var button = document.getElementById("notifications");
        if (button) {
    button.addEventListener("click", function (e) {
        Notification.requestPermission().then(function (result) {
            if (result === "granted") {
                testNotification();
            }
        });
    });
        }
    }

    function testNotification() {
        var notifTitle = "You just subscribed yourself to notifications!";
        var notifBody = "We told you not to do it.";
        var notifImg = "/images/logo_2.png";
        var options = {
    body: notifBody,
            icon: notifImg
        }
        var notif = new Notification(notifTitle, options);
        setTimeout(testNotification, 30000);
    }