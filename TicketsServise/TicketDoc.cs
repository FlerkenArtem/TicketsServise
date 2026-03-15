using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace TicketsServise
{
    public class TicketDoc
    {
        public byte[] Generate(Ticket t, Event e)
        {
            byte[] doc = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x =>
                    x.FontSize(14));

                    page.Header()
                    .Text($"Билет на мероприятие: {e.Name}")
                    .SemiBold()
                    .FontSize(24)
                    .AlignCenter();

                    page.Content()
                    .AlignLeft()
                    .Text($"Дата и время: {e.EventDateTime.ToString()}" +
                          $"\nПлощадка проведения: {e.Place}" +
                          $"\nМесто в зале: {t.place}" +
                          $"\nСтоимость: {t.price.ToString()} рублей");

                    page.Footer()
                    .AlignBottom()
                    .Text($"Организатор мероприятия: {e.Orzanizer}" +
                          "\nБилет создан с помощью программы \"Платформа для организации мероприятий и продажи билетов\".")
                    .Thin()
                    .FontSize(8);
                });
            }).GeneratePdf();
            return doc;
        }
    }
}
