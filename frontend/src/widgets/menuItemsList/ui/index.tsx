import React from "react";
import { MenuItem } from "../../../entities/menuItem";
import "./index.scss";
import { IMenu } from "../../../shared/interfaces/IMenu";
interface IProps {
  data: IMenu[];
}

export const MenuItemsList = ({ data }: IProps) => {
  return (
    <div>
      <h1 id="chosen-name">Выбор дня</h1>
      <div className="menu-items-list">
        {data.map((item, index) => {
          return (
            <MenuItem
              id={item.id}
              key={index}
              name={item.name}
              ingredients={item.ingredients}
              price={item.price}
              imgUrl={item.imgUrl}
            />
          );
        })}
      </div>
    </div>
  );
};
