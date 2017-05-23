# Handlebars.NET Test

This project uses two files on disk to simulate an email templating engine:

- `Layout.hbs` - a layout file containing common markup
- `FileReady.hbs` - a sample file that references the layout, and contains specific messaging to let a user know that their file is ready to download.

The generated HTML looks like it properly uses the model, except it doesn't appear to work in `Layout.hbs`.

`Layout.hbs` contains the following markup:

```html
<div class="footer">
    Please view our <a href="{{SiteUrl}}/privacypolicy/">privacy policy</a>
</div>
```

And this is the output for that section:

```html
<div class="footer">
    Please view our <a href="/privacypolicy/">privacy policy</a>
</div>
```

Even though `FileReady.hbs` properly fills in `{{SiteUrl}}`, `Layout.hbs` does not.

Is there a configuration setting or special method to enable this?