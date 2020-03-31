import bulmaCalendar from 'bulma-calendar/dist/js/bulma-calendar.js';
import defaultOptions from 'bulma-calendar/src/js/defaultOptions';

const makeCall = function (calc, callback) {
    callback({
        startDate : calc.data.startDate,
        startTime : calc.data.startTime,
        endDate : calc.data.endDate,
        endTime : calc.data.endTime,
        mode : calc.data.options.type,
        isRange : calc.data.options.isRange
    });
};

const timers = [];

const makeThrottledCall = function (delay, calc, callback) {
    if (timers[calc._id]) {
        return
    }
    timers[calc._id] = setTimeout(function () {
        makeCall(calc, callback);
        timers[calc._id] = undefined;
    }, delay)
};

const isAlreadyAttached = function (selector) {
    const elm = document.querySelector(selector);
    return elm.className === "is-hidden";
};

export function attach (id, callback, optObj) {
    const options = {
        ...defaultOptions,
        ...optObj
    };
    const selector = 'input[id="'+id+'"]';
    const isAttached = isAlreadyAttached(selector);
    
    if (isAttached === false) {
        const calendars = bulmaCalendar.attach(selector, options);
        calendars.forEach(calendar => {
            if (calendar.element.id === id) {
                calendar.removeListeners('hide');
                calendar.removeListeners('select');
                calendar.on('hide', calc => makeThrottledCall(10, calc, callback));
                calendar.on('select', calc => makeThrottledCall(10, calc, callback));
            }
        });
    } else {
        const element = document.querySelector(selector);
        if (element) {
            element.bulmaCalendar.removeListeners('hide');
            element.bulmaCalendar.removeListeners('select');
            element.bulmaCalendar.on('hide', calc => makeThrottledCall(10, calc, callback));
            element.bulmaCalendar.on('select', calc => makeThrottledCall(10, calc, callback));
        }
    }
}