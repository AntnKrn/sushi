import { createSlice, PayloadAction } from "@reduxjs/toolkit";
interface IIsAuthState {
  value: boolean;
}
const initialState: IIsAuthState = {
  value: false,
};
const isAuthSlice = createSlice({
  name: "chechIsUserAuthorized",
  initialState,
  reducers: {
    checkIsAuth: (state) => {
      if (document.cookie === "") state.value = false;
      else {
        state.value = true;
      }
    },
  },
});

export const { checkIsAuth } = isAuthSlice.actions;
export default isAuthSlice.reducer;
