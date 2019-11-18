using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.bill{
	
	
	
	public class BillHeaderInfoHelper : TBeanSerializer<BillHeaderInfo>
	{
		
		public static BillHeaderInfoHelper OBJ = new BillHeaderInfoHelper();
		
		public static BillHeaderInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BillHeaderInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("bill_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBill_no(value);
					}
					
					
					
					
					
					if ("channel_coop_mode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetChannel_coop_mode(value);
					}
					
					
					
					
					
					if ("sponsor".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSponsor(value);
					}
					
					
					
					
					
					if ("bill_amount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBill_amount(value);
					}
					
					
					
					
					
					if ("bill_detail_count".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetBill_detail_count(value);
					}
					
					
					
					
					
					if ("finish_flag".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFinish_flag(value);
					}
					
					
					
					
					
					if ("bill_detail_info_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.bill.BillDetailInfo> value;
						
						value = new List<com.vip.vop.cup.api.bill.BillDetailInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.bill.BillDetailInfo elem0;
								
								elem0 = new com.vip.vop.cup.api.bill.BillDetailInfo();
								com.vip.vop.cup.api.bill.BillDetailInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBill_detail_info_list(value);
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
		
		
		public void Write(BillHeaderInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBill_no() != null) {
				
				oprot.WriteFieldBegin("bill_no");
				oprot.WriteString(structs.GetBill_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bill_no can not be null!");
			}
			
			
			if(structs.GetChannel_coop_mode() != null) {
				
				oprot.WriteFieldBegin("channel_coop_mode");
				oprot.WriteString(structs.GetChannel_coop_mode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("channel_coop_mode can not be null!");
			}
			
			
			if(structs.GetSponsor() != null) {
				
				oprot.WriteFieldBegin("sponsor");
				oprot.WriteString(structs.GetSponsor());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sponsor can not be null!");
			}
			
			
			if(structs.GetBill_amount() != null) {
				
				oprot.WriteFieldBegin("bill_amount");
				oprot.WriteString(structs.GetBill_amount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bill_amount can not be null!");
			}
			
			
			if(structs.GetBill_detail_count() != null) {
				
				oprot.WriteFieldBegin("bill_detail_count");
				oprot.WriteI32((int)structs.GetBill_detail_count()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bill_detail_count can not be null!");
			}
			
			
			if(structs.GetFinish_flag() != null) {
				
				oprot.WriteFieldBegin("finish_flag");
				oprot.WriteString(structs.GetFinish_flag());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("finish_flag can not be null!");
			}
			
			
			if(structs.GetBill_detail_info_list() != null) {
				
				oprot.WriteFieldBegin("bill_detail_info_list");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.bill.BillDetailInfo _item0 in structs.GetBill_detail_info_list()){
					
					
					com.vip.vop.cup.api.bill.BillDetailInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bill_detail_info_list can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BillHeaderInfo bean){
			
			
		}
		
	}
	
}