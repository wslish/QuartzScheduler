import { QuartzSchedulerTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: QuartzSchedulerTemplatePage;

  beforeEach(() => {
    page = new QuartzSchedulerTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
