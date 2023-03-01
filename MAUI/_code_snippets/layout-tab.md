
## Build Tabs in the AppShell
```
    // add namespace
    xmlns:pages="clr-namespace:MauiWhatsAppClone.Pages"
    

    <TabBar>
        <Tab>
            <ShellContent ContentTemplate="{DataTemplate pages:ChatsPage}" Title="Chats" />
            <ShellContent ContentTemplate="{DataTemplate pages:StatusPage}" Title="Status" />
            <ShellContent ContentTemplate="{DataTemplate pages:CallsPage}" Title="Calls" />
        </Tab>
    </TabBar>
```
