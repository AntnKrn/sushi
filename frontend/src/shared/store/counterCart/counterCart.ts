import { createSlice, PayloadAction } from "@reduxjs/toolkit";
let localstorage = JSON.parse(window.localStorage.getItem("cart")!);

interface ICounterState {
  value?: number;
}

const initialState: ICounterState = {
  value: localstorage?.length,
};

const counterSlice = createSlice({
  name: "counter",
  initialState,
  reducers: {
    increment: (state, action: PayloadAction<number>) => {
      if (window.localStorage.getItem("cart") === null) {
        localstorage = [];
      }
      const productId = localstorage.find(
        (item: any) => item.idItem === action.payload
      );
      if (productId) {
        productId.quantity += 1;
      } else {
        localstorage.push({ idItem: action.payload, quantity: 1 });
        if (typeof state.value === "number") state.value += 1;
      }
      localStorage.setItem("cart", JSON.stringify(localstorage));
    },
    decrement: (state) => {
      if (state.value) state.value -= 1;
    },
  },
});

export const { increment, decrement } = counterSlice.actions;
export default counterSlice.reducer;
