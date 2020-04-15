describe('ui-components', () => {
  beforeEach(() => cy.visit('/iframe.html?id=selectablecardcomponent--primary'));

  it('should render the component', () => {
    cy.get('copa-filmes-selectable-card').should('exist');
  });
});
