using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.ap.service{
	
	
	
	public class InvTransDetailReqItemHelper : TBeanSerializer<InvTransDetailReqItem>
	{
		
		public static InvTransDetailReqItemHelper OBJ = new InvTransDetailReqItemHelper();
		
		public static InvTransDetailReqItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InvTransDetailReqItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pager".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.ap.service.Pager value;
						
						value = new com.vip.fcs.ap.service.Pager();
						com.vip.fcs.ap.service.PagerHelper.getInstance().Read(value, iprot);
						
						structs.SetPager(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("po".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo(value);
					}
					
					
					
					
					
					if ("businessPeriod".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBusinessPeriod(value);
					}
					
					
					
					
					
					if ("itemNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemNo(value);
					}
					
					
					
					
					
					if ("lineType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLineType(value);
					}
					
					
					
					
					
					if ("brandCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandCode(value);
					}
					
					
					
					
					
					if ("whType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWhType(value);
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
		
		
		public void Write(InvTransDetailReqItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPager() != null) {
				
				oprot.WriteFieldBegin("pager");
				
				com.vip.fcs.ap.service.PagerHelper.getInstance().Write(structs.GetPager(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendorCode can not be null!");
			}
			
			
			if(structs.GetPo() != null) {
				
				oprot.WriteFieldBegin("po");
				oprot.WriteString(structs.GetPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBusinessPeriod() != null) {
				
				oprot.WriteFieldBegin("businessPeriod");
				oprot.WriteString(structs.GetBusinessPeriod());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemNo() != null) {
				
				oprot.WriteFieldBegin("itemNo");
				oprot.WriteString(structs.GetItemNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLineType() != null) {
				
				oprot.WriteFieldBegin("lineType");
				oprot.WriteString(structs.GetLineType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandCode() != null) {
				
				oprot.WriteFieldBegin("brandCode");
				oprot.WriteString(structs.GetBrandCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWhType() != null) {
				
				oprot.WriteFieldBegin("whType");
				oprot.WriteString(structs.GetWhType());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InvTransDetailReqItem bean){
			
			
		}
		
	}
	
}