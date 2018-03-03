# Documentation

## Sitecore Hackathon 2018 - Commerce Instagram

## Summary

**Category:** Sitecore Commerce & SXA

**Team:** Sitecore eXtender

**Author:** Mohamed Krimi

**Plugin Pupose:** 
Commerce Instagram is a Sitecore Commerce SXA Feature that let you enhance your product page experience with UGC (User Genereted Content) from instagram account/feed/tag. 
This module will connect your product page to an Instagram Account/Feed/Tag and grab additional images for your product. 
This module will help your saving you time editing and processing images of all your products and help you increase visibility on instagram and selling.  

## Features & Road Map

Currently the module will only support following supports following coverage of the following Instagram APIs: 

- [x] Get Product Images from Instagram Feeds
- [] Filter Product Images by product tag
- [] Gives discount, if related product has been featured on your instagram account

Add parameters to component to specify : 
- [] Get user timeline feed
- [] Get all user media by username
- [] Get media by its id
- [] Get user info by its user name
- [] Get current user info
- [] Get tag feed by tag value
- [] Get current user media
 
## Pre-requisites

Before installing this module you need : 

1. To install Sitecore XP 9.0 update 1
2. To Deploy Sitecore Commerce 9.0 initial release (With default Storefront)

## Installation

To install this module:

1. Open your Sitecore <your-website>/sitecore
2. Login as an Administrator
3. Navigate to Control Panel 
4. Click on Administration/install a package
5. Upload the package (TODO Add link here)  
6. Click Next Next Next >> Finish

## Configuration

How do you configure your module once it is installed? Are there items that need to be updated with settings, or maybe config files need to have keys updated?

Remember you are using Markdown, you can provide code samples too:

```xml
<?xml version="1.0"?>
<!--
  Purpose: Configuration settings for my hackathon module
-->
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <settings>
      <setting name="MyModule.Setting" value="Hackathon" />
    </settings>
  </sitecore>
</configuration>
```

## Usage

Provide documentation  about your module, how do the users use your module, where are things located, what do icns mean, are there any secret shortcuts etc.

Please include screenshots where necessary. You can add images to the `./images` folder and then link to them from your documentation:

![Hackathon Logo](images/hackathon.png?raw=true "Hackathon Logo")

You can embed images of different formats too:

![Deal With It](images/deal-with-it.gif?raw=true "Deal With It")

And you can embed external images too:

![Random](https://placeimg.com/480/240/any "Random")

## Video

Direct Link [direct link](https://www.youtube.com/watch?v=EpNhxW4pNKk)

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/EpNhxW4pNKk/0.jpg)](https://www.youtube.com/watch?v=EpNhxW4pNKk)
