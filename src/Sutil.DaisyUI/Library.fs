﻿namespace Sutil.DaisyUI

open Sutil

module Daisy =
    module Button =
        let button elements =
            Html.button [ Attr.className "btn"; yield! elements ]

        let primary = Attr.className "btn-primary"
        let secondary = Attr.className "btn-secondary"
        let accent = Attr.className "btn-accent"
        let info = Attr.className "btn-info"
        let success = Attr.className "btn-success"
        let warning = Attr.className "btn-warning"
        let error = Attr.className "btn-error"
        let ghost = Attr.className "btn-ghost"
        let link = Attr.className "btn-link"
        let outline = Attr.className "btn-outline"
        let active = Attr.className "btn-active"
        let disabled = Attr.className "btn-disabled"
        let glass = Attr.className "glass"
        let loading = Attr.className "loading"
        let noAnimation = Attr.className "no-animation"
        let large = Attr.className "btn-lg"
        let medium = Attr.className "btn-md"
        let small = Attr.className "btn-sm"
        let extraSmall = Attr.className "btn-xs"
        let wide = Attr.className "btn-wide"
        let block = Attr.className "btn-block"
        let circle = Attr.className "btn-circle"
        let square = Attr.className "btn-square"

    module Card =
        let card elements =
            Html.div [ Attr.className "card"; yield! elements ]

        let body elements =
            Html.div [ Attr.className "card-body"; yield! elements ]

        let title elements =
            Html.h2 [ Attr.className "card-title"; yield! elements ]

        let actions elements =
            Html.div [ Attr.className "card-actions"; yield! elements ]

        let bordered = Attr.className "card-bordered"
        let imageFull = Attr.className "image-full"
        let normal = Attr.className "card-normal"
        let compact = Attr.className "card-compact"
        let side = Attr.className "card-side"

    module Alert =
        let alert elements =
            Html.div [ Attr.className "alert"; yield! elements ]

        let info = Attr.className "alert-info"
        let success = Attr.className "alert-success"
        let warning = Attr.className "alert-warning"
        let error = Attr.className "alert-error"

    module Avatar =
        let avatar elements =
            Html.div [ Attr.className "avatar"; yield! elements ]

        let avatarGroup elements =
            Html.div [ Attr.className "avatar-group"; yield! elements ]

        let online = Attr.className "online"
        let offline = Attr.className "offline"
        let placeholder = Attr.className "placeholder"

    module Badge =
        let badge elements =
            Html.span [ Attr.className "badge"; yield! elements ]
        
        let outline = Attr.className "outline"
        let primary = Attr.className "badge-primary"
        let secondary = Attr.className "badge-secondary"
        let accent = Attr.className "badge-accent"
        let ghost = Attr.className "badge-ghost"
        let info = Attr.className "badge-info"
        let success = Attr.className "badge-success"
        let warning = Attr.className "badge-warning"
        let error = Attr.className "badge-error"
        
        let large = Attr.className "badge-lg"
        let medium = Attr.className "badge-md"
        let small = Attr.className "badge-sm"
        let extraSmall = Attr.className "badge-xs"
    
    module Table =
        let table elements =
            Html.table [ Attr.className "table"; yield! elements ]
        
        let zebra = Attr.className "table-zebra"
        let active = Attr.className "active"
        let hover = Attr.className "hover"
        
        let normal = Attr.className "table-normal"
        let compact = Attr.className "table-compact"