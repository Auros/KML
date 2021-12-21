# KML
 Kron Markup Language (KML) is a markup language designed to support and parse into other text formats like Markdown or Unity's TMP Rich Text.

## Capabilities
* **Bolding**
* *Italicizing* 
* <u>Underlining</u>
* ~~Strikethrough~~
* HEX, RGB, and HSL coloring
* [Links](https://example.com)
* Heading Sizes

## Why? And Limitations
This is for building a news service for modding communities. There are many formats for which this news can be viewed, so having a parser to convert all of these to the various formats used throughout the community makes sense. The parsing can be lossy depending on which format it's being converted to, but it will try its best to make the most accurate representation of the content.

## Example (Theoretical)

```
**Bolding**
*Italicizing*
__Underlining__
~~Strikethrough~~

[hex(#00ffff)]Cyan Text[/hex]
[rgb(255, 255, 255)]White Text[/rgb]
[hsl(0, 100%, 50%)]Red Text[/hsl]

[link(https://example.com)]Click on me![/link]
[h(1)]Big Heading[/h]
[h(6)]Little Heading[/h]
```

## Planned Support
Support is planned for C# and Typescript, with official conversions to HTML, Markdown, GitHub Markdown, Discord Markdown, and Unity's TMP Rich Text.