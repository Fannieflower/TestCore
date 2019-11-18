using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.bill{
	
	
	
	public class BillDetailInfoHelper : TBeanSerializer<BillDetailInfo>
	{
		
		public static BillDetailInfoHelper OBJ = new BillDetailInfoHelper();
		
		public static BillDetailInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BillDetailInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("channel_data_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetChannel_data_id(value);
					}
					
					
					
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("receipt_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceipt_no(value);
					}
					
					
					
					
					
					if ("receipt_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceipt_type(value);
					}
					
					
					
					
					
					if ("prod_sku_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetProd_sku_id(value);
					}
					
					
					
					
					
					if ("ext_goods_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExt_goods_no(value);
					}
					
					
					
					
					
					if ("ext_goods_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExt_goods_name(value);
					}
					
					
					
					
					
					if ("schedule_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSchedule_id(value);
					}
					
					
					
					
					
					if ("category".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategory(value);
					}
					
					
					
					
					
					if ("tax_rate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTax_rate(value);
					}
					
					
					
					
					
					if ("commission_ratio".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommission_ratio(value);
					}
					
					
					
					
					
					if ("settlement_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSettlement_status(value);
					}
					
					
					
					
					
					if ("cost_occurrence_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCost_occurrence_time(value);
					}
					
					
					
					
					
					if ("cost_chargeable_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCost_chargeable_time(value);
					}
					
					
					
					
					
					if ("cost_settlement_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCost_settlement_time(value);
					}
					
					
					
					
					
					if ("cost_item".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCost_item(value);
					}
					
					
					
					
					
					if ("amount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAmount(value);
					}
					
					
					
					
					
					if ("currency".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrency(value);
					}
					
					
					
					
					
					if ("income_expenses_direction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIncome_expenses_direction(value);
					}
					
					
					
					
					
					if ("money_serialNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMoney_serialNo(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(BillDetailInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetChannel_data_id() != null) {
				
				oprot.WriteFieldBegin("channel_data_id");
				oprot.WriteI64((long)structs.GetChannel_data_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("channel_data_id can not be null!");
			}
			
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_sn can not be null!");
			}
			
			
			if(structs.GetReceipt_no() != null) {
				
				oprot.WriteFieldBegin("receipt_no");
				oprot.WriteString(structs.GetReceipt_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("receipt_no can not be null!");
			}
			
			
			if(structs.GetReceipt_type() != null) {
				
				oprot.WriteFieldBegin("receipt_type");
				oprot.WriteString(structs.GetReceipt_type());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("receipt_type can not be null!");
			}
			
			
			if(structs.GetProd_sku_id() != null) {
				
				oprot.WriteFieldBegin("prod_sku_id");
				oprot.WriteI64((long)structs.GetProd_sku_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("prod_sku_id can not be null!");
			}
			
			
			if(structs.GetExt_goods_no() != null) {
				
				oprot.WriteFieldBegin("ext_goods_no");
				oprot.WriteString(structs.GetExt_goods_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("ext_goods_no can not be null!");
			}
			
			
			if(structs.GetExt_goods_name() != null) {
				
				oprot.WriteFieldBegin("ext_goods_name");
				oprot.WriteString(structs.GetExt_goods_name());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("ext_goods_name can not be null!");
			}
			
			
			if(structs.GetSchedule_id() != null) {
				
				oprot.WriteFieldBegin("schedule_id");
				oprot.WriteI64((long)structs.GetSchedule_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategory() != null) {
				
				oprot.WriteFieldBegin("category");
				oprot.WriteString(structs.GetCategory());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTax_rate() != null) {
				
				oprot.WriteFieldBegin("tax_rate");
				oprot.WriteString(structs.GetTax_rate());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("tax_rate can not be null!");
			}
			
			
			if(structs.GetCommission_ratio() != null) {
				
				oprot.WriteFieldBegin("commission_ratio");
				oprot.WriteString(structs.GetCommission_ratio());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSettlement_status() != null) {
				
				oprot.WriteFieldBegin("settlement_status");
				oprot.WriteString(structs.GetSettlement_status());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("settlement_status can not be null!");
			}
			
			
			if(structs.GetCost_occurrence_time() != null) {
				
				oprot.WriteFieldBegin("cost_occurrence_time");
				oprot.WriteI64((long)structs.GetCost_occurrence_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost_occurrence_time can not be null!");
			}
			
			
			if(structs.GetCost_chargeable_time() != null) {
				
				oprot.WriteFieldBegin("cost_chargeable_time");
				oprot.WriteI64((long)structs.GetCost_chargeable_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost_chargeable_time can not be null!");
			}
			
			
			if(structs.GetCost_settlement_time() != null) {
				
				oprot.WriteFieldBegin("cost_settlement_time");
				oprot.WriteI64((long)structs.GetCost_settlement_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCost_item() != null) {
				
				oprot.WriteFieldBegin("cost_item");
				oprot.WriteString(structs.GetCost_item());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost_item can not be null!");
			}
			
			
			if(structs.GetAmount() != null) {
				
				oprot.WriteFieldBegin("amount");
				oprot.WriteString(structs.GetAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("amount can not be null!");
			}
			
			
			if(structs.GetCurrency() != null) {
				
				oprot.WriteFieldBegin("currency");
				oprot.WriteString(structs.GetCurrency());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("currency can not be null!");
			}
			
			
			if(structs.GetIncome_expenses_direction() != null) {
				
				oprot.WriteFieldBegin("income_expenses_direction");
				oprot.WriteString(structs.GetIncome_expenses_direction());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("income_expenses_direction can not be null!");
			}
			
			
			if(structs.GetMoney_serialNo() != null) {
				
				oprot.WriteFieldBegin("money_serialNo");
				oprot.WriteString(structs.GetMoney_serialNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BillDetailInfo bean){
			
			
		}
		
	}
	
}