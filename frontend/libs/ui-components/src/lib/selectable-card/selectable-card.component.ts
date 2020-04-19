import { Component, OnInit, ContentChild, HostBinding, ViewEncapsulation, ElementRef, Optional, Inject } from '@angular/core';
import { MatCheckbox, MAT_CHECKBOX_DEFAULT_OPTIONS, MatCheckboxDefaultOptions } from '@angular/material/checkbox';
import {MatCheckboxHarness} from '@angular/material/checkbox/testing';

@Component({
  selector: 'ui-selectable-card',
  templateUrl: './selectable-card.component.html',
  styleUrls: ['./selectable-card.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class SelectableCardComponent {

  @ContentChild(MatCheckbox) checkbox: MatCheckbox;

  @HostBinding('class')
  get colorClass() {
    return `mat-${this.checkbox?.color || this._options.color}`;
  };

  @HostBinding('class.ui-selectable-card') componentClass = true;

  @HostBinding('class.selected')
  get selected() {
    return this.checkbox?.checked;
  };

  get disabled() {
    return this.checkbox?.disabled;
  }

  constructor(
    @Optional() @Inject(MAT_CHECKBOX_DEFAULT_OPTIONS)
    private _options?: MatCheckboxDefaultOptions
  ) {}

  async onCardClick(e) {
    if(!this.checkbox || e.target.firstElementChild?.type === 'checkbox') {
      return;
    }
    await this.checkbox._inputElement.nativeElement.click();
  }
}
