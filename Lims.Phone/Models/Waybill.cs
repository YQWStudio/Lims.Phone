using System;
using System.Collections.Generic;
using System.Text;

namespace Lims.Phone.Models
{
    /// <summary>
    /// 运单数据类
    /// </summary>
    public class Waybill
    {
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string ConsigneePhone { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string ConsigneeName { get; set; }

        /// <summary>
        /// 收货人地址
        /// </summary>
        public string ConsigneeAddress { get; set; }

        /// <summary>
        /// 发货人电话
        /// </summary>
        public string ShipperPhone { get; set; }

        /// <summary>
        /// 发货人姓名
        /// </summary>
        public string ShipperName { get; set; }

        /// <summary>
        /// 发货站点
        /// </summary>
        public string ShippingSite { get; set; }

        /// <summary>
        /// 发货城市
        /// </summary>
        public string ShippingCity { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 提货网点
        /// </summary>
        public string PickupLocations { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// 提货方式
        /// </summary>
        public string PickupMethod { get; set; }

        /// <summary>
        /// 货物名称
        /// </summary>
        public string CargoName { get; set; }

        /// <summary>
        /// 制单员
        /// </summary>
        public string OrderMaker { get; set; }

        /// <summary>
        /// 发货日期，含时间
        /// </summary>
        public DateTime ConsignmentDate { get; set; }

        /// <summary>
        /// 到站城市
        /// </summary>
        public string ArrivalCity { get; set; }

        /// <summary>
        /// 条码号
        /// </summary>
        public string BarCode { get; set; }

        /// <summary>
        /// 提货电话
        /// </summary>
        public string PickupPhone { get; set; }

        /// <summary>
        /// 到站电话
        /// </summary>
        public string ArrivalPhone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 货物件数
        /// </summary>
        public int NumberOfPieces { get; set; }

        /// <summary>
        /// 垫付款
        /// </summary>
        public decimal Advances { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        public decimal FreightRates { get; set; }

        /// <summary>
        /// 保价金额
        /// </summary>
        public decimal GuaranteedAmount { get; set; }

        /// <summary>
        /// 保价费用
        /// </summary>
        public decimal GuaranteeFee { get; set; }

        /// <summary>
        /// 手续费
        /// </summary>
        public decimal HandlingFee { get; set; }

        /// <summary>
        /// 提货费
        /// </summary>
        public decimal PickupFee { get; set; }

        /// <summary>
        /// 工本费
        /// </summary>
        public decimal WorkbookFee { get; set; }

        /// <summary>
        /// 提付
        /// </summary>
        public decimal Withdrawals { get; set; }

        /// <summary>
        /// 现付
        /// </summary>
        public decimal PayNow { get; set; }

        /// <summary>
        /// 回付
        /// </summary>
        public decimal Payback { get; set; }

        /// <summary>
        /// 代收金额
        /// </summary>
        public decimal CollectionAmount { get; set; }

        /// <summary>
        /// 现返金额
        /// </summary>
        public decimal Cashback { get; set; }

        /// <summary>
        /// 欠返金额
        /// </summary>
        public decimal OwedBack { get; set; }

        /// <summary>
        /// 送货费
        /// </summary>
        public decimal DeliveryFees { get; set; }

        /// <summary>
        /// 应收款
        /// </summary>
        public decimal AccountsReceivable { get; set; }

        /// <summary>
        /// 总运费
        /// </summary>
        public decimal TotalShippingCost { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        public string PaymentMethods { get; set; }

        /// <summary>
        /// 中转方式
        /// </summary>
        public string TransitMethod { get; set; }

        /// <summary>
        /// 运单号码
        /// </summary>
        public string WaybillNumber { get; set; }

        /// <summary>
        /// 是否回单
        /// </summary>
        public bool ReturnOrder { get; set; }
    }
}
