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

    module Divider =
        let divider elements =
            Html.div [ Attr.className "divider"; yield! elements ]

        let vertical = Attr.className "divider-vertical"
        let horizontal = Attr.className "divider-horizontal"

    module Stack =
        let stack elements =
            Html.div [ Attr.className "stack"; yield! elements ]

    module Toast =
        let toast elements =
            Html.div [ Attr.className "toast"; yield! elements ]

        let start = Attr.className "toast-start"
        let center = Attr.className "toast-center"
        let end' = Attr.className "toast-end"
        let top = Attr.className "toast-top"
        let middle = Attr.className "toast-middle"
        let bottom = Attr.className "toast-bottom"

    module Steps =
        let steps elements =
            Html.ul [ Attr.className "steps"; yield! elements ]

        let step elements =
            Html.li [ Attr.className "step"; yield! elements ]

        let primary = Attr.className "step-primary"
        let secondary = Attr.className "step-secondary"
        let accent = Attr.className "step-accent"
        let info = Attr.className "step-info"
        let success = Attr.className "step-success"
        let warning = Attr.className "step-warning"
        let error = Attr.className "step-error"

        let vertical = Attr.className "steps-vertical"
        let horizontal = Attr.className "steps-horizontal"

    module Navbar =
        let navbar elements =
            Html.div [ Attr.className "navbar"; yield! elements ]
        
        let navbarStart elements =
            Html.div [ Attr.className "navbar-start"; yield! elements ]
        
        let navbarCenter elements =
            Html.div [ Attr.className "navbar-center"; yield! elements ]
        
        let navbarEnd elements =
            Html.div [ Attr.className "navbar-end"; yield! elements ]

    module Tabs =
        let tabs elements =
            Html.div [ Attr.className "tabs"; yield! elements ]
        
        let tab elements =
            Html.a [ Attr.className "tab"; yield! elements ]
        
        let boxed = Attr.className "tabs-boxed"
        let active = Attr.className "tab-active"
        let disabled = Attr.className "tab-disabled"
        let bordered = Attr.className "tab-bordered"
        let lifted = Attr.className "tab-lifted"
        
        let extraSmall = Attr.className "tab-xs"
        let small = Attr.className "tab-sm"
        let medium = Attr.className "tab-md"
        let large = Attr.className "tab-lg"

    module Swap =
        let swap elements =
            Html.div [ Attr.className "swap"; yield! elements ]
        
        let swapOnAttr = Attr.className "swap-on"
        let swapOffAttr = Attr.className "swap-off"
        
        let swapOn elements =
            Html.div [ swapOnAttr; yield! elements ]
        
        let swapOff elements =
            Html.div [ swapOffAttr; yield! elements ]
        
        let active = Attr.className "swap-active"
        let rotate = Attr.className "swap-rotate"
        let flip = Attr.className "swap-flip"

    module Countdown =
        let countdown elements =
            Html.span [ Attr.className "countdown"; yield! elements ]
    
    module RadialProgress =
        let radialProgress elements =
            Html.div [ Attr.className "radial-progress"; yield! elements ]

    module Stat =
        let stats elements =
            Html.div [ Attr.className "stats"; yield! elements ]
        
        let stat elements =
            Html.div [ Attr.className "stat"; yield! elements ]
        
        let title elements =
            Html.div [ Attr.className "stat-title"; yield! elements ]
        
        let value elements =
            Html.div [ Attr.className "stat-value"; yield! elements ]
        
        let desc elements =
            Html.div [ Attr.className "state-desc"; yield! elements ]
        
        let figure elements =
            Html.div [ Attr.className "stat-figure"; yield! elements ]
        
        let actions elements =
            Html.div [ Attr.className "stat-actions"; yield! elements ]
        
        let horizontal = Attr.className "stat-horizontal"
        let vertical = Attr.className "stat-vertical"