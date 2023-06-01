namespace Sutil.DaisyUI

open System
open Sutil

module Daisy =
    module Button =
        let buttonAttr = Attr.className "btn"

        let button elements =
            Html.button [ buttonAttr; yield! elements ]

        let neutral = Attr.className "btn-neutral"
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

        let neutral = Attr.className "badge-neutral"
        let outline = Attr.className "badge-outline"
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
        
        let dropdown elements =
            Html.ul [ Attr.className "menu-dropdown"; yield! elements ]

        let dropdownToggle elements =
            Html.span [ Attr.className "menu-dropdown-toggle"; yield! elements ]

        let dropdownShow = Attr.className "menu-dropdown-show"
        
        let disabled = Attr.className "disabled"
        let active = Attr.className "active"
        let focus = Attr.className "focus"

        let extraSmall = Attr.className "menu-xs"
        let small = Attr.className "menu-sm"
        let medium = Attr.className "menu-md"
        let large = Attr.className "menu-lg"
        
        let vertical = Attr.className "menu-vertical"
        let horizontal = Attr.className "menu-horizontal"

    [<Obsolete("This component is deprecated and will be removed in the next major version. Use Join instead.")>]
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

    module Checkbox =
        let checkbox elements =
            Html.input [ Attr.typeCheckbox; Attr.className "checkbox"; yield! elements ]

        let primary = Attr.className "checkbox-primary"
        let secondary = Attr.className "checkbox-secondary"
        let accent = Attr.className "checkbox-accent"
        let success = Attr.className "checkbox-success"
        let warning = Attr.className "checkbox-warning"
        let info = Attr.className "checkbox-info"
        let error = Attr.className "checkbox-error"

        let large = Attr.className "checkbox-lg"
        let medium = Attr.className "checkbox-md"
        let small = Attr.className "checkbox-sm"
        let extraSmall = Attr.className "checkbox-sm"

    module FormControl =
        let formControl elements =
            Html.div [ Attr.className "form-control"; yield! elements ]

    module Label =
        let label elements =
            Html.label [ Attr.className "label"; yield! elements ]

        let labelTextAttr = Attr.className "label-text"
        let labelTextAltAttr = Attr.className "label-text-alt"

        let labelText (value: string) =
            Html.span [ labelTextAttr; Attr.text value ]

        let labelTextAlt (value: string) =
            Html.span [ labelTextAltAttr; Attr.text value ]

    module Input =
        let input elements =
            Html.input [ Attr.typeText; Attr.className "input"; yield! elements ]

        let bordered = Attr.className "input-bordered"
        let ghost = Attr.className "input-ghost"
        let primary = Attr.className "input-primary"
        let secondary = Attr.className "input-secondary"
        let accent = Attr.className "input-accent"
        let info = Attr.className "input-info"
        let success = Attr.className "input-success"
        let warning = Attr.className "input-warning"
        let error = Attr.className "input-error"

        let large = Attr.className "input-lg"
        let medium = Attr.className "input-md"
        let small = Attr.className "input-sm"
        let extraSmall = Attr.className "input-xs"

    module Radio =
        let radio elements =
            Html.input [ Attr.typeRadio; Attr.className "radio"; yield! elements ]

        let primary = Attr.className "radio-primary"
        let secondary = Attr.className "radio-secondary"
        let accent = Attr.className "radio-accent"
        let success = Attr.className "radio-success"
        let warning = Attr.className "radio-warning"
        let info = Attr.className "radio-info"
        let error = Attr.className "radio-error"

        let large = Attr.className "radio-lg"
        let medium = Attr.className "radio-md"
        let small = Attr.className "radio-sm"
        let extraSmall = Attr.className "radio-xs"

    module Range =
        let range elements =
            Html.input [ Attr.typeRange; Attr.className "range"; yield! elements ]

        let primary = Attr.className "range-primary"
        let secondary = Attr.className "range-secondary"
        let accent = Attr.className "range-accent"
        let success = Attr.className "range-success"
        let warning = Attr.className "range-warning"
        let info = Attr.className "range-info"
        let error = Attr.className "range-error"

        let large = Attr.className "range-lg"
        let medium = Attr.className "range-md"
        let small = Attr.className "range-sm"
        let extraSmall = Attr.className "range-xs"

    module FileInput =
        let fileInput elements =
            Html.input [ Attr.typeFile; Attr.className "file-input"; yield! elements ]

        let bordered = Attr.className "file-input-bordered"
        let ghost = Attr.className "file-input-ghost"
        let primary = Attr.className "file-input-primary"
        let secondary = Attr.className "file-input-secondary"
        let accent = Attr.className "file-input-accent"
        let info = Attr.className "file-input-info"
        let success = Attr.className "file-input-success"
        let warning = Attr.className "file-input-warning"
        let error = Attr.className "file-input-error"

        let large = Attr.className "file-input-lg"
        let medium = Attr.className "file-input-md"
        let small = Attr.className "file-input-sm"
        let extraSmall = Attr.className "file-input-xs"

    module Rating =
        let rating elements =
            Html.div [ Attr.className "rating"; yield! elements ]

        let half = Attr.className "rating-half"
        let hidden = Attr.className "rating-hidden"

        let large = Attr.className "rating-lg"
        let medium = Attr.className "rating-medium"
        let small = Attr.className "rating-sm"
        let extraSmall = Attr.className "rating-xs"

    module Select =
        let select elements =
            Html.select [ Attr.className "select"; yield! elements ]

        let bordered = Attr.className "select-bordered"
        let ghost = Attr.className "select-ghost"
        let primary = Attr.className "select-primary"
        let secondary = Attr.className "select-secondary"
        let accent = Attr.className "select-accent"
        let info = Attr.className "select-info"
        let success = Attr.className "select-success"
        let warning = Attr.className "select-warning"
        let error = Attr.className "select-error"

        let large = Attr.className "select-lg"
        let medium = Attr.className "select-md"
        let small = Attr.className "select-sm"
        let extraSmall = Attr.className "select-xs"

    module TextArea =
        let textArea elements =
            Html.textarea [ Attr.className "textarea"; yield! elements ]

        let bordered = Attr.className "textarea-bordered"
        let ghost = Attr.className "textarea-ghost"
        let primary = Attr.className "textarea-primary"
        let secondary = Attr.className "textarea-secondary"
        let accent = Attr.className "textarea-accent"
        let info = Attr.className "textarea-info"
        let success = Attr.className "textarea-success"
        let warning = Attr.className "textarea-warning"
        let error = Attr.className "textarea-error"

        let large = Attr.className "textarea-lg"
        let medium = Attr.className "textarea-md"
        let small = Attr.className "textarea-sm"
        let extraSmall = Attr.className "textarea-xs"

    module Toggle =
        let toggle elements =
            Html.input [ Attr.typeCheckbox; Attr.className "toggle" ]

        let primary = Attr.className "toggle-primary"
        let secondary = Attr.className "toggle-secondary"
        let accent = Attr.className "toggle-accent"
        let success = Attr.className "toggle-success"
        let warning = Attr.className "toggle-warning"
        let info = Attr.className "toggle-info"
        let error = Attr.className "toggle-error"

        let large = Attr.className "toggle-lg"
        let medium = Attr.className "toggle-md"
        let small = Attr.className "toggle-sm"
        let extraSmall = Attr.className "toggle-xs"

    module Hero =
        let hero elements =
            Html.div [ Attr.className "hero"; yield! elements ]

        let content elements =
            Html.div [ Attr.className "hero-content"; yield! elements ]

        let overlay elements =
            Html.div [ Attr.className "hero-overlay"; yield! elements ]

    module Mask =
        let maskAttr = Attr.className "mask"

        let mask elements = Html.img [ maskAttr; yield! elements ]

        let squircle = Attr.className "mask-squircle"
        let heart = Attr.className "mask-heart"
        let hexagon = Attr.className "mask-hexagon"
        let hexagon2 = Attr.className "mask-hexagon-2"
        let decagon = Attr.className "mask-decagon"
        let pentagon = Attr.className "mask-pentagon"
        let diamond = Attr.className "mask-diamond"
        let square = Attr.className "mask-square"
        let circle = Attr.className "mask-circle"
        let parallelogram = Attr.className "mask-parallelogram"
        let parallelogram2 = Attr.className "mask-parallelogram-2"
        let parallelogram3 = Attr.className "mask-parallelogram-3"
        let parallelogram4 = Attr.className "mask-parallelogram-4"
        let star = Attr.className "mask-star"
        let star2 = Attr.className "mask-star-2"
        let triangle = Attr.className "mask-triangle"
        let triangle2 = Attr.className "mask-triangle-2"
        let triangle3 = Attr.className "mask-triangle-3"
        let triangle4 = Attr.className "mask-triangle-4"
        let half1 = Attr.className "mask-half-1"
        let half2 = Attr.className "mask-half-2"

    module Code =
        let code elements =
            Html.div [ Attr.className "mockup-code"; yield! elements ]

    module Phone =
        let phone elements =
            Html.div [ Attr.className "mockup-phone"; yield! elements ]

    module Window =
        let window elements =
            Html.div [ Attr.className "mockup-window"; yield! elements ]

    module BottomNav =
        let bottomNav elements =
            Html.div [ Attr.className "btm-nav"; yield! elements ]

        let active = Attr.className "active"
        let disabled = Attr.className "disabled"

        let extraSmall = Attr.className "btm-nav-xs"
        let small = Attr.className "btm-nav-sm"
        let medium = Attr.className "btm-nav-md"
        let large = Attr.className "btm-nav-lg"

    [<Obsolete("This component is deprecated and will be removed in the next major version. Use Join instead.")>]
    module InputGroup =
        let inputGroup elements =
            Html.label [ Attr.className "input-group"; yield! elements ]

        let large = Attr.className "input-group-lg"
        let medium = Attr.className "input-group-md"
        let small = Attr.className "input-group-sm"
        let extraSmall = Attr.className "input-group-xs"

        let vertical = Attr.className "input-group-vertical"

    module Indicator =
        let indicator elements =
            Html.div [ Attr.className "indicator"; yield! elements ]

        let item elements =
            Html.span [ Attr.className "indicator-item"; yield! elements ]

        let start = Attr.className "indicator-start"
        let center = Attr.className "indicator-center"
        let end' = Attr.className "indicator-end"
        let top = Attr.className "indicator-top"
        let middle = Attr.className "indicator-middle"
        let bottom = Attr.className "indicator-bottom"

    module Drawer =
        let drawer elements =
            Html.div [ Attr.className "drawer"; yield! elements ]

        let toggle elements =
            Html.input [ Attr.typeCheckbox; Attr.className "drawer-toggle"; yield! elements ]

        let content elements =
            Html.div [ Attr.className "drawer-contents"; yield! elements ]

        let side elements =
            Html.div [ Attr.className "drawer-side"; yield! elements ]

        let overlay elements =
            Html.label [ Attr.className "drawer-overlay"; yield! elements ]

        let end' = Attr.className "drawer-end"
        let open' = Attr.className "drawer-open"

    module Modal =
        let modalAttr = Attr.className "modal"

        let modal elements =
            Html.dialog [ modalAttr; yield! elements ]

        let box elements =
            Html.div [ Attr.className "modal-box"; yield! elements ]

        let action elements =
            Html.div [ Attr.className "modal-action"; yield! elements ]

        let toggle elements =
            Html.input [ Attr.typeCheckbox; Attr.className "modal-toggle"; yield! elements ]

        let backdrop elements =
            Html.form [ Attr.method "dialog"; Attr.className "backdrop"; yield! elements ]

        let open' = Attr.className "modal-open"
        let top = Attr.className "modal-top"
        let bottom = Attr.className "modal-bottom"
        let middle = Attr.className "modal-middle"

    module Dropdown =
        let dropdown elements =
            Html.div [ Attr.className "dropdown"; yield! elements ]

        let contentAttr = Attr.className "dropdown-content"

        let content elements =
            Html.div [ contentAttr; yield! elements ]

        let end' = Attr.className "dropdown-end"
        let top = Attr.className "dropdown-top"
        let bottom = Attr.className "dropdown-bottom"
        let left = Attr.className "dropdown-left"
        let right = Attr.className "dropdown-right"
        let hover = Attr.className "dropdown-hover"
        let open' = Attr.className "dropdown-open"

    module Loading =
        let loading elements =
            Html.span [ Attr.className "loading"; yield! elements ]

        let spinner = Attr.className "loading-spinner"
        let dots = Attr.className "loading-dots"
        let ring = Attr.className "loading-ring"
        let ball = Attr.className "loading-ball"
        let bars = Attr.className "loading-bars"
        let infinity = Attr.className "loading-infinity"

    module Join =
        let join elements =
            Html.div [ Attr.className "join"; yield! elements ]

        let item = Attr.className "join-item"
        let vertical = Attr.className "join-vertical"
        let horizontal = Attr.className "join-horizontal"
