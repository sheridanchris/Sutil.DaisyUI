namespace Sutil.DaisyUI

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

    module Tooltip =
        let tooltip elements =
            Html.div [ Attr.className "tooltip"; yield! elements ]

        let text value = Attr.custom ("data-tip", value)

        let open' = Attr.className "tooltip-open"
        let top = Attr.className "tooltip-top"
        let bottom = Attr.className "tooltip-bottom"
        let left = Attr.className "tooltip-left"
        let right = Attr.className "tooltip-right"

        let primary = Attr.className "tooltip-primary"
        let secondary = Attr.className "tooltip-secondary"
        let accent = Attr.className "tooltip-accent"
        let info = Attr.className "tooltip-info"
        let success = Attr.className "tooltip-success"
        let warning = Attr.className "tooltip-warning"
        let error = Attr.className "tooltip-error"

    module Breadcrumbs =
        let breadcrumbs elements =
            Html.div [ Attr.className "breadcrumbs"; yield! elements ]

    module Link =
        let link elements =
            Html.a [ Attr.className "link"; yield! elements ]

        let neutral = Attr.className "link-neutral"
        let primary = Attr.className "link-primary"
        let secondary = Attr.className "link-secondary"
        let accent = Attr.className "link-accent"
        let success = Attr.className "link-success"
        let info = Attr.className "link-info"
        let warning = Attr.className "link-warning"
        let error = Attr.className "link-error"
        let hover = Attr.className "link-hover"

    module Menu =
        let menu elements =
            Html.ul [ Attr.className "menu"; yield! elements ]

        let title (value: string) =
            Html.li [ Attr.className "menu-title"; Html.span value ]

        let disabled = Attr.className "disabled"
        let active = Attr.className "active"
        let bordered = Attr.className "bordered"
        let hoverBordered = Attr.className "hover-bordered"

        let normal = Attr.className "menu-normal"
        let compact = Attr.className "menu-compact"
        let vertical = Attr.className "menu-vertical"
        let horizontal = Attr.className "menu-horizontal"

    module ButtonGroup =
        let buttonGroup elements =
            Html.div [ Attr.className "btn-group"; yield! elements ]

        let horizontal = Attr.className "btn-group-horizontal"
        let vertical = Attr.className "btn-group-vertical"

    module Carousel =
        let carousel elements =
            Html.div [ Attr.className "carousel"; yield! elements ]

        let carouselItem elements =
            Html.div [ Attr.className "carousel-item"; yield! elements ]

        let center = Attr.className "carousel-center"
        let end' = Attr.className "carousel-end"
        let vertical = Attr.className "carousel-vertical"

    // TODO: should this be split into two components? OR...
    // should there be a distinction between chat and chat-bubble.
    module ChatBubble =
        let chat elements =
            Html.div [ Attr.className "chat"; yield! elements ]

        let image elements =
            Html.div [ Attr.className "chat-image"; yield! elements ]

        let header elements =
            Html.div [ Attr.className "chat-header"; yield! elements ]

        let footer elements =
            Html.div [ Attr.className "chat-footer"; yield! elements ]

        let chatBubble elements =
            Html.div [ Attr.className "chat-bubble"; yield! elements ]

        let start = Attr.className "chat-start"
        let end' = Attr.className "chat-end"

        let primary = Attr.className "chat-bubble-primary"
        let secondary = Attr.className "chat-bubble-secondary"
        let accent = Attr.className "chat-bubble-accent"
        let info = Attr.className "chat-bubble-info"
        let success = Attr.className "chat-bubble-success"
        let warning = Attr.className "chat-bubble-warning"
        let error = Attr.className "chat-bubble-error"

    module Collapse =
        let collapse elements =
            Html.div [ Attr.className "collapse"; yield! elements ]

        let title elements =
            Html.div [ Attr.className "collapse-title"; yield! elements ]

        let content elements =
            Html.div [ Attr.className "collapse-content"; yield! elements ]

        let arrow = Attr.className "collapse-arrow"
        let plus = Attr.className "collapse-plus"
        let open' = Attr.className "collapse-open"
        let close = Attr.className "collapse-close"

    module Kbd =
        let kbd elements =
            Html.kbd [ Attr.className "kbd"; yield! elements ]

        let large = Attr.className "kbd-large"
        let medium = Attr.className "kbd-md"
        let small = Attr.className "kbd-small"
        let extraSmall = Attr.className "kbd-xs"

    module Progress =
        let progress elements =
            Html.progress [ Attr.className "progress"; yield! elements ]

        let primary = Attr.className "progress-primary"
        let secondary = Attr.className "progress-secondary"
        let accent = Attr.className "progress-accent"
        let info = Attr.className "progress-info"
        let success = Attr.className "progress-success"
        let warning = Attr.className "progress-warning"
        let error = Attr.className "progress-error"

    module Footer =
        let footer elements =
            Html.footer [ Attr.className "footer"; yield! elements ]

        let title (value: string) =
            Html.span [ Attr.className "footer-title"; Attr.value value ]

        let center = Attr.className "footer-center"

    module Artboard =
        let artboard elements =
            Html.div [ Attr.className "artboard"; yield! elements ]

        let demo = Attr.className "artboard-demo"
        let phone1 = Attr.className "phone-1"
        let phone2 = Attr.className "phone-2"
