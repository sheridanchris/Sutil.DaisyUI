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
