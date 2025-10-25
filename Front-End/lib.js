function echo(msg) {
  console.log(msg);
}
let add = (n1, n2) => {
  console.log(n1 + n2);
};

//export default 資料;
export default {
  echo: echo,
  add: add,
};
