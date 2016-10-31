function updateEventFunction() {

        debugger;
        scheduler.attachEvent("onTemplatesReady", function () {
            alert("eventblock");
            scheduler.templates.event_text = function (start, end, event) {

                var dateToStr = scheduler.date.date_to_str("%H:%i");

                return "<br>" + event.id +
                    "<br>" + dateToStr(event.end_date) +
                    "<br>" + dateToStr(event.start_date) +
                    "<br>" + event.Color +
                    "sampleready" + "<br>" + "sampletext";
            }
        });
    }