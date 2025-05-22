# ClearConfig

![Static Badge](https://img.shields.io/badge/MIT-blue?label=License)
![Static Badge](https://img.shields.io/badge/C%23-green?label=Language)
![GitHub last commit](https://img.shields.io/github/last-commit/Nokskiy/ClearConfig)
![GitHub repo size](https://img.shields.io/github/repo-size/Nokskiy/ClearConfig)

> [!IMPORTANT]
> **Early Development Notice**
> The program is currently in active development. Features and documentation may change.

---

## 📌 Table of Contents

- [📖 About](#-about)
- [🚀 Getting Started](#-getting-started)
  - [Command Line Usage](#-command-line-usage)
  - [Configuration Guide](#-configuration-guide)
- [🤝 Contributing](#-contributing)
- [🐛 Issue Reporting](#-issue-reporting)

---

## 📖 About

ClearConfig is a lightweight utility designed for **fast, configurable file deletion**. Specify file patterns in simple config files, and let ClearConfig handle the cleanup efficiently.

---

## 🚀 Getting Started

### ⚙️ Config Usage

The config file located in the folder with the executable (must be named ClearConfig.config) should contain the following line:

`link C:\Example\ClearConfig.config`

The config file specified in the previous item must include the following content:

`fe .txt`

### 💻 Command Line Usage

| Command        | Description                                  | Parameters               |
| -------------- | -------------------------------------------- | ------------------------ |
| `help`         | Show all available commands                  | -                        |
| `update_links` | Refresh config file references               | `list_all` (true/false)  |
| `remove`       | Execute deletion from config files           | `config_path` (optional) |
| `remove_rec`   | Execute deletion from config files recursive | `config_path` (optional) |

---

**Example:**
`remove C:\Example\ClearConfig.config`

---

## 🤝 Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/your-feature`)
3. Commit your changes (`git commit -m 'Add some feature'`)
4. Push to the branch (`git push origin feature/your-feature`)
5. Open a Pull Request

---

## 🐛 Issue Reporting

Found a bug? Please **help** us by:

1. Checking existing issues to avoid duplicates
2. Providing detailed steps to reproduce
3. Including your OS/environment details
4. Describing expected vs actual behavior
