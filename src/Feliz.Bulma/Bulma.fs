﻿namespace Feliz.Bulma

open Feliz

type Bulma =
    static member inline container props = ElementBuilders.Div.props "container" props
    static member inline container (elms:#seq<ReactElement>) = ElementBuilders.Div.children "container" elms
    static member inline container elm = ElementBuilders.Div.valueElm "container" elm
    static member inline container s = ElementBuilders.Div.valueStr "container" s
    static member inline container i = ElementBuilders.Div.valueInt "container" i
    
    static member inline level props = ElementBuilders.Nav.props "level" props
    static member inline level (elms:#seq<ReactElement>) = ElementBuilders.Nav.children "level" elms
    static member inline level elm = ElementBuilders.Nav.children "level" elm
    
    static member inline levelLeft props = ElementBuilders.Div.props "level-left" props
    static member inline levelLeft (elms:#seq<ReactElement>) = ElementBuilders.Div.children "level-left" elms
    static member inline levelLeft elm = ElementBuilders.Div.valueElm "level-left" elm
    static member inline levelLeft s = ElementBuilders.Div.valueStr "level-left" s
    static member inline levelLeft i = ElementBuilders.Div.valueInt "level-left" i
    
    static member inline levelRight props = ElementBuilders.Div.props "level-right" props
    static member inline levelRight (elms:#seq<ReactElement>) = ElementBuilders.Div.children "level-right" elms
    static member inline levelRight elm = ElementBuilders.Div.valueElm "level-right" elm
    static member inline levelRight s = ElementBuilders.Div.valueStr "level-right" s
    static member inline levelRight i = ElementBuilders.Div.valueInt "level-right" i
    
    static member inline levelItem props = ElementBuilders.Div.props "level-item" props
    static member inline levelItem (elms:#seq<ReactElement>) = ElementBuilders.Div.children "level-item" elms
    static member inline levelItem elm = ElementBuilders.Div.valueElm "level-item" elm
    static member inline levelItem s = ElementBuilders.Div.valueStr "level-item" s
    static member inline levelItem i = ElementBuilders.Div.valueInt "level-item" i

    static member inline media props = ElementBuilders.Article.props "media" props
    static member inline media (elms:#seq<ReactElement>) = ElementBuilders.Article.children "media" elms
    static member inline media elm = ElementBuilders.Article.valueElm "media" elm
    
    static member inline mediaLeft props = ElementBuilders.Div.props "media-left" props
    static member inline mediaLeft (elms:#seq<ReactElement>) = ElementBuilders.Div.children "media-left" elms
    static member inline mediaLeft elm = ElementBuilders.Div.valueElm "media-left" elm
    static member inline mediaLeft s = ElementBuilders.Div.valueStr "media-left" s
    static member inline mediaLeft i = ElementBuilders.Div.valueInt "media-left" i
    
    static member inline mediaRight props = ElementBuilders.Div.props "media-right" props
    static member inline mediaRight (elms:#seq<ReactElement>) = ElementBuilders.Div.children "media-right" elms
    static member inline mediaRight elm = ElementBuilders.Div.valueElm "media-right" elm
    static member inline mediaRight s = ElementBuilders.Div.valueStr "media-right" s
    static member inline mediaRight i = ElementBuilders.Div.valueInt "media-right" i
    
    static member inline mediaContent props = ElementBuilders.Div.props "media-content" props
    static member inline mediaContent (elms:#seq<ReactElement>) = ElementBuilders.Div.children "media-content" elms
    static member inline mediaContent elm = ElementBuilders.Div.valueElm "media-content" elm
    static member inline mediaContent s = ElementBuilders.Div.valueStr "media-content" s
    static member inline mediaContent i = ElementBuilders.Div.valueInt "media-content" i
    
    static member inline hero props = ElementBuilders.Div.props "hero" props
    static member inline hero (elms:#seq<ReactElement>) = ElementBuilders.Div.children "hero" elms
    static member inline hero elm = ElementBuilders.Div.valueElm "hero" elm
    static member inline hero s = ElementBuilders.Div.valueStr "hero" s
    static member inline hero i = ElementBuilders.Div.valueInt "hero" i
    
    static member inline heroBody props = ElementBuilders.Div.props "hero-body" props
    static member inline heroBody (elms:#seq<ReactElement>) = ElementBuilders.Div.children "hero-body" elms
    static member inline heroBody elm = ElementBuilders.Div.valueElm "hero-body" elm
    static member inline heroBody s = ElementBuilders.Div.valueStr "hero-body" s
    static member inline heroBody i = ElementBuilders.Div.valueInt "hero-body" i
    
    static member inline heroHead props = ElementBuilders.Div.props "hero-head" props
    static member inline heroHead (elms:#seq<ReactElement>) = ElementBuilders.Div.children "hero-head" elms
    static member inline heroHead elm = ElementBuilders.Div.valueElm "hero-head" elm
    static member inline heroHead s = ElementBuilders.Div.valueStr "hero-head" s
    static member inline heroHead i = ElementBuilders.Div.valueInt "hero-head" i

    static member inline heroFoot props = ElementBuilders.Div.props "hero-foot" props
    static member inline heroFoot (elms:#seq<ReactElement>) = ElementBuilders.Div.children "hero-foot" elms
    static member inline heroFoot elm = ElementBuilders.Div.valueElm "hero-foot" elm
    static member inline heroFoot s = ElementBuilders.Div.valueStr "hero-foot" s
    static member inline heroFoot i = ElementBuilders.Div.valueInt "hero-foot" i
    
    static member inline section props = ElementBuilders.Section.props "section" props
    static member inline section (elms:#seq<ReactElement>) = ElementBuilders.Section.children "section" elms
    
    static member inline footer props = ElementBuilders.Footer.props "footer" props
    static member inline footer (elms:#seq<ReactElement>) = ElementBuilders.Footer.children "footer" elms
    static member inline footer elm = ElementBuilders.Footer.valueElm "footer" elm
    
    static member inline tile props = ElementBuilders.Div.props "tile" props
    static member inline tile (elms:#seq<ReactElement>) = ElementBuilders.Div.children "tile" elms
    static member inline tile elm = ElementBuilders.Div.valueElm "tile" elm
    static member inline tile s = ElementBuilders.Div.valueStr "tile" s
    static member inline tile i = ElementBuilders.Div.valueInt "tile" i
    
    static member inline columns props = ElementBuilders.Div.props "columns" props
    static member inline columns (elms:#seq<ReactElement>) = ElementBuilders.Div.children "columns" elms
    static member inline columns elm = ElementBuilders.Div.valueElm "columns" elm
    static member inline columns s = ElementBuilders.Div.valueStr "columns" s
    static member inline columns i = ElementBuilders.Div.valueInt "columns" i
    
    static member inline column props = ElementBuilders.Div.props "column" props
    static member inline column (elms:#seq<ReactElement>) = ElementBuilders.Div.children "column" elms
    static member inline column elm = ElementBuilders.Div.valueElm "column" elm
    static member inline column s = ElementBuilders.Div.valueStr "column" s
    static member inline column i = ElementBuilders.Div.valueInt "column" i
    
    static member inline field props = ElementBuilders.Div.props "field" props
    static member inline field (elms:#seq<ReactElement>) = ElementBuilders.Div.children "field" elms
    static member inline field elm = ElementBuilders.Div.valueElm "field" elm
    static member inline field s = ElementBuilders.Div.valueStr "field" s
    static member inline field i = ElementBuilders.Div.valueInt "field" i
    
    static member inline label props = ElementBuilders.Label.props "label" props
    static member inline label (elms:#seq<ReactElement>) = ElementBuilders.Label.children "label" elms
    static member inline label elm = ElementBuilders.Label.valueElm "label" elm
    
    static member inline fieldLabel props = ElementBuilders.Div.props "field-label" props
    static member inline fieldLabel (elms:#seq<ReactElement>) = ElementBuilders.Div.children "field-label" elms
    static member inline fieldLabel elm = ElementBuilders.Div.valueElm "field-label" elm
    static member inline fieldLabel s = ElementBuilders.Div.valueStr "field-label" s
    static member inline fieldLabel i = ElementBuilders.Div.valueInt "field-label" i
    
    static member inline fieldBody props = ElementBuilders.Div.props "field-body" props
    static member inline fieldBody (elms:#seq<ReactElement>) = ElementBuilders.Div.children "field-body" elms
    static member inline fieldBody elm = ElementBuilders.Div.valueElm "field-body" elm
    static member inline fieldBody s = ElementBuilders.Div.valueStr "field-body" s
    static member inline fieldBody i = ElementBuilders.Div.valueInt "field-body" i
    
    static member inline control props = ElementBuilders.Div.props "control" props
    static member inline control (elms:#seq<ReactElement>) = ElementBuilders.Div.children "control" elms
    static member inline control elm = ElementBuilders.Div.valueElm "control" elm
    
    static member inline input props = ElementBuilders.Input.props "input" props
    
    static member inline textarea props = ElementBuilders.Textarea.props "textarea" props
    static member inline textarea (elms:#seq<ReactElement>) = ElementBuilders.Textarea.children "textarea" elms
    static member inline textarea elm = ElementBuilders.Textarea.valueElm "textarea" elm        
    
    static member inline select props = Html.div [ prop.className "select"; prop.children [ Html.select props ] ]
    static member inline select (elms:#seq<ReactElement>) = Html.div [ prop.className "select"; prop.children [ Html.select elms ] ]
    static member inline select (elm:ReactElement) = Html.div [ prop.className "select"; prop.children [ Html.select [ elm ] ] ]
    
    static member inline button props = ElementBuilders.Button.props "button" props
    static member inline button (elms:#seq<ReactElement>) = ElementBuilders.Button.children "button" elms
    static member inline button elm = ElementBuilders.Button.valueElm "button" elm
    static member inline button s = ElementBuilders.Button.valueStr "button" s
    static member inline button i = ElementBuilders.Button.valueInt "button" i
    
    static member inline checkboxLabel props = ElementBuilders.Label.props "checkbox" props
    static member inline checkboxLabel (elms:#seq<ReactElement>) = ElementBuilders.Label.children "checkbox" elms
    static member inline checkboxLabel elm = ElementBuilders.Label.valueElm "checkbox" elm
    
    static member inline checkboxInput props = ElementBuilders.Input.props "checkbox" props
    
    static member inline radioLabel props = ElementBuilders.Label.props "radio" props
    static member inline radioLabel (elms:#seq<ReactElement>) = ElementBuilders.Label.children "radio" elms
    static member inline radioLabel elm = ElementBuilders.Label.valueElm "radio" elm

    static member inline radioInput props = ElementBuilders.Input.props "radio" props
        
    static member inline icon props = ElementBuilders.Span.props "icon" props
    static member inline icon (elms:#seq<ReactElement>) = ElementBuilders.Span.children "icon" elms
    static member inline icon elm = ElementBuilders.Span.valueElm "icon" elm
    
    static member inline file props = ElementBuilders.Div.props "file" props
    static member inline file (elms:#seq<ReactElement>) = ElementBuilders.Div.children "file" elms
    static member inline file elm = ElementBuilders.Div.valueElm "file" elm
    
    static member inline fileLabel props = ElementBuilders.Label.props "file-label" props
    static member inline fileLabel (elms:#seq<ReactElement>) = ElementBuilders.Label.children "file-label" elms
    static member inline fileLabel elm = ElementBuilders.Label.valueElm "file-label" elm
    static member inline fileLabel s = ElementBuilders.Span.valueStr "file-label" s
    static member inline fileLabel i = ElementBuilders.Span.valueInt "file-label" i
    
    static member inline fileInput props = ElementBuilders.Input.props "file-input" props
    
    static member inline fileCta props = ElementBuilders.Span.props "file-cta" props
    static member inline fileCta (elms:#seq<ReactElement>) = ElementBuilders.Span.children "file-cta" elms
    static member inline fileCta elm = ElementBuilders.Span.valueElm "file-cta" elm
    
    static member inline fileIcon props = ElementBuilders.Span.props "file-icon" props
    static member inline fileIcon (elms:#seq<ReactElement>) = ElementBuilders.Span.children "file-icon" elms
    static member inline fileIcon elm = ElementBuilders.Span.valueElm "file-icon" elm
    
    static member inline fileName props = ElementBuilders.Span.props "file-name" props
    static member inline fileName (elms:#seq<ReactElement>) = ElementBuilders.Span.children "file-name" elms
    static member inline fileName elm = ElementBuilders.Span.valueElm "file-name" elm
    static member inline fileName s = ElementBuilders.Span.valueStr "file-name" s
    static member inline fileName i = ElementBuilders.Span.valueInt "file-name" i
    
    static member inline box props = ElementBuilders.Div.props "box" props
    static member inline box (elms:#seq<ReactElement>) = ElementBuilders.Div.children "box" elms
    static member inline box elm = ElementBuilders.Div.valueElm "box" elm
    static member inline box s = ElementBuilders.Div.valueStr "box" s
    static member inline box i = ElementBuilders.Div.valueInt "box" i
    
    static member inline buttons props = ElementBuilders.Div.props "buttons" props
    static member inline buttons (elms:#seq<ReactElement>) = ElementBuilders.Div.children "buttons" elms
    static member inline buttons elm = ElementBuilders.Div.valueElm "buttons" elm
    
    static member inline content props = ElementBuilders.Div.props "content" props
    static member inline content (elms:#seq<ReactElement>) = ElementBuilders.Div.children "content" elms
    static member inline content elm = ElementBuilders.Div.valueElm "content" elm
    static member inline content s = ElementBuilders.Div.valueStr "content" s
    static member inline content i = ElementBuilders.Div.valueInt "content" i
    
    static member inline delete props = ElementBuilders.Button.props "delete" props
    
    static member inline image props = ElementBuilders.Figure.props "image" props
    static member inline image (elms:#seq<ReactElement>) = ElementBuilders.Figure.children "image" elms
    static member inline image elm = ElementBuilders.Figure.valueElm "image" elm
    
    static member inline notification props = ElementBuilders.Div.props "notification" props
    static member inline notification (elms:#seq<ReactElement>) = ElementBuilders.Div.children "notification" elms
    static member inline notification elm = ElementBuilders.Div.valueElm "notification" elm
    static member inline notification s = ElementBuilders.Div.valueStr "notification" s
    static member inline notification i = ElementBuilders.Div.valueInt "notification" i
    
    static member inline progress props = ElementBuilders.Div.props "progress" props
    static member inline progress (elms:#seq<ReactElement>) = ElementBuilders.Div.children "progress" elms
    static member inline progress elm = ElementBuilders.Div.valueElm "progress" elm
    static member inline progress s = ElementBuilders.Div.valueStr "progress" s
    static member inline progress i = ElementBuilders.Div.valueInt "progress" i