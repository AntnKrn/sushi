import React from "react";
import { Header } from "../../../widgets/header";
import { Footer } from "../../../widgets/footer";
import { BlogList } from "../../../widgets/blogList/ui";
import "./index.scss";

export const Blog = () => {
  return (
    <div className="blog-page">
      <Header />
      <BlogList />
      <Footer />
    </div>
  );
};
