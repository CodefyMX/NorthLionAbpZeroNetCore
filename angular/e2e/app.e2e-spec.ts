import { ZeroTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: ZeroTemplatePage;

  beforeEach(() => {
    page = new ZeroTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
