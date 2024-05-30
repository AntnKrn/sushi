import { configureStore } from "@reduxjs/toolkit";
import counterReducer from "./counterCart/counterCart";
import checkAuthReducer from "./auth/auth";

export const store = configureStore({
  reducer: {
    counter: counterReducer,
    chechAuth: checkAuthReducer,
  },
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;
