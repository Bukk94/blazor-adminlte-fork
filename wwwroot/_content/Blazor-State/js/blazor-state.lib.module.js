import { blazorState } from './BlazorState.js';
import { ReduxDevTools } from './ReduxDevTools.js';
import { BlazorStateName, InitializeJavaScriptInteropName, ReduxDevToolsFactoryName, ReduxDevToolsName, } from './Constants.js';
function InitializeJavaScriptInterop(JsonRequestHandler) {
    console.log("InitializeJavaScriptInterop");
    blazorState.jsonRequestHandler = JsonRequestHandler;
}
;
function ReduxDevToolsFactory() {
    const reduxDevTools = new ReduxDevTools();
    blazorState.reduxDevTools = reduxDevTools;
    window[ReduxDevToolsName] = reduxDevTools;
    return reduxDevTools.IsEnabled;
}
export function beforeStart(options, extensions) {
    console.log("timewarp blazor-state beforeStart");
    window[InitializeJavaScriptInteropName] = InitializeJavaScriptInterop;
    window[ReduxDevToolsFactoryName] = ReduxDevToolsFactory;
    window[BlazorStateName] = blazorState;
}
export function afterStarted(blazor) {
    console.log("timewarp blazor-state afterStarted");
}
//# sourceMappingURL=blazor-state.lib.module.js.map