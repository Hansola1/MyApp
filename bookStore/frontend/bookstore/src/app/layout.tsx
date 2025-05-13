'use client'; 

import "./globals.css";
import { Layout, Menu } from "antd";
import Link from "next/link";
import { Inter } from "next/font/google";

const { Header, Content, Footer } = Layout;

const inter = Inter({
  variable: "--font-inter",
  subsets: ["latin"],
});

const items = [
  { key: "home", label: <Link href="/">Home</Link> },
  { key: "books", label: <Link href="/books">Books</Link> },
];

export default function RootLayout({ children }: { children: React.ReactNode }) {
  return (
    <html lang="en" className={inter.variable}>
      <body>
        <Layout style={{ minHeight: "100vh" }}>
          <Header>
            <Menu
              theme="dark"
              mode="horizontal"
              items={items}
              style={{ flex: 1, minWidth: 0 }}
            />
          </Header>
          <Content style={{ padding: "0 48px" }}>
            {children}
          </Content>
          <Footer style={{ textAlign: "center" }}>
            Ляляляля надо все понять лялляляля
          </Footer>
        </Layout>
      </body>
    </html>
  );
}