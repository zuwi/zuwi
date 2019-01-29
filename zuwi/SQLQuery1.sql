--insert into Sites(Name) values ('TestSite');
--insert into Widgets(PartialName) values ('Test');
--insert into SiteWidget(Sites_Id, Widgets_Id) values (1,1);
--insert into WidgetData(Sites_Id, Widgets_Id, [Key], [Value]) values (1, 1, 'title', 'Der Titel des Widgets');


--truncate table WidgetData;
--GO
--truncate table SiteWidget;
--GO
--truncate table Sites;

--truncate table Widgets;

--delete from Widgets where Id = 4;
--
select * from Sites;
select * from Widgets;
select * from RequiredWidgetKeys;
select * from SiteWidget;
select * from WidgetData;
