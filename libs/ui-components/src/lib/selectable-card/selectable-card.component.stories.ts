import { moduleMetadata, storiesOf } from '@storybook/angular';

import { SelectableCardModule } from './selectable-card.module';


storiesOf('SelectableCard', module).add('Default', () => ({
  template: `
    <div>
    <ui-selectable-card>
      <div class="mat-card-header-text">
        <mat-checkbox></mat-checkbox>
        <h2>Shiba Inu</h2>
        <small>dooog</small>
      </div>
    </ui-selectable-card>
    </div>
  `,
  styles: [
    'div { max-width: 250px }',
    'h2 { margin-bottom: 0 }'
  ],
  moduleMetadata: {
    imports: [SelectableCardModule]
  }
}));
