using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.ap.service{
	
	
	
	public class VendorBillSourceRespItemHelper : TBeanSerializer<VendorBillSourceRespItem>
	{
		
		public static VendorBillSourceRespItemHelper OBJ = new VendorBillSourceRespItemHelper();
		
		public static VendorBillSourceRespItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VendorBillSourceRespItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("code".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCode(value);
					}
					
					
					
					
					
					if ("msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMsg(value);
					}
					
					
					
					
					
					if ("count".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCount(value);
					}
					
					
					
					
					
					if ("billDetailReqItem".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem value;
						
						value = new com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem();
						com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItemHelper.getInstance().Read(value, iprot);
						
						structs.SetBillDetailReqItem(value);
					}
					
					
					
					
					
					if ("billDetails".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.fcs.ap.service.VendorBillGoodsSource> value;
						
						value = new List<com.vip.fcs.ap.service.VendorBillGoodsSource>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.fcs.ap.service.VendorBillGoodsSource elem2;
								
								elem2 = new com.vip.fcs.ap.service.VendorBillGoodsSource();
								com.vip.fcs.ap.service.VendorBillGoodsSourceHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBillDetails(value);
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
		
		
		public void Write(VendorBillSourceRespItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCode() != null) {
				
				oprot.WriteFieldBegin("code");
				oprot.WriteI32((int)structs.GetCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMsg() != null) {
				
				oprot.WriteFieldBegin("msg");
				oprot.WriteString(structs.GetMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCount() != null) {
				
				oprot.WriteFieldBegin("count");
				oprot.WriteI64((long)structs.GetCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBillDetailReqItem() != null) {
				
				oprot.WriteFieldBegin("billDetailReqItem");
				
				com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItemHelper.getInstance().Write(structs.GetBillDetailReqItem(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBillDetails() != null) {
				
				oprot.WriteFieldBegin("billDetails");
				
				oprot.WriteListBegin();
				foreach(com.vip.fcs.ap.service.VendorBillGoodsSource _item0 in structs.GetBillDetails()){
					
					
					com.vip.fcs.ap.service.VendorBillGoodsSourceHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VendorBillSourceRespItem bean){
			
			
		}
		
	}
	
}