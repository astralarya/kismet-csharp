#!/usr/bin/env bash


workspace_dir="$PWD/$( dirname "${BASH_SOURCE[0]}" )"
tmp_dir=$(mktemp -d -t kismet-csharp--XXXXXXXX)

cd "$tmp_dir"
git clone https://github.com/astralarya/kismet-antlr.git
cd kismet-antlr
chmod a+x gradlew

./gradlew generateGrammarSource \
  -PantlrLanguage=CSharp \
  -PantlrArguments="-no-listener -visitor -package KismetLanguage.Grammar"

rm -r "${workspace_dir}"/KismetLanguage/Grammar
cp -r \
  build/generated-src/antlr/main \
  "${workspace_dir}"/KismetLanguage/Grammar

rm -rf "$tmp_dir"