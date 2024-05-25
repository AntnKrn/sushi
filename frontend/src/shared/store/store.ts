export const addItemToCart = (id: number): void => {
  let store = JSON.parse(window.localStorage.getItem("cart")!);
  if (window.localStorage.getItem("cart") === null) {
    store = [];
  }
  const productId = store.find((item: any) => item.idItem === id);
  if (productId) {
    productId.quantity += 1;
  } else {
    store.push({ idItem: id, quantity: 1 });
  }
  localStorage.setItem("cart", JSON.stringify(store));
};
