import React from "react";
import "./index.scss";
import { BlogItem } from "../../../entities/blogItem/ui";

export const BlogList = () => {
  return (
    <div className="blog-wrapper">
      <h6>Blog</h6>
      <div className="blog-items">
        <BlogItem />
        <BlogItem />
        <BlogItem />
        <BlogItem />
        <BlogItem />
      </div>
    </div>
  );
};
