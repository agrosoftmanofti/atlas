#!/usr/bin/env bash
set -e

# Installs .NET SDK 9.0 on Debian/Ubuntu systems
if command -v dotnet >/dev/null; then
  echo ".NET SDK is already installed"
  exit 0
fi

wget https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y dotnet-sdk-9.0

