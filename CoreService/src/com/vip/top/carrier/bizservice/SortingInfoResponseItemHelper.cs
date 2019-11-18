using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class SortingInfoResponseItemHelper : TBeanSerializer<SortingInfoResponseItem>
	{
		
		public static SortingInfoResponseItemHelper OBJ = new SortingInfoResponseItemHelper();
		
		public static SortingInfoResponseItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SortingInfoResponseItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("sortingCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSortingCode(value);
					}
					
					
					
					
					
					if ("carrierPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierPointCode(value);
					}
					
					
					
					
					
					if ("carrierPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierPointName(value);
					}
					
					
					
					
					
					if ("referenceNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReferenceNo(value);
					}
					
					
					
					
					
					if ("bizCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizCode(value);
					}
					
					
					
					
					
					if ("bizMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizMsg(value);
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
		
		
		public void Write(SortingInfoResponseItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSortingCode() != null) {
				
				oprot.WriteFieldBegin("sortingCode");
				oprot.WriteString(structs.GetSortingCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrierPointCode() != null) {
				
				oprot.WriteFieldBegin("carrierPointCode");
				oprot.WriteString(structs.GetCarrierPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrierPointName() != null) {
				
				oprot.WriteFieldBegin("carrierPointName");
				oprot.WriteString(structs.GetCarrierPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReferenceNo() != null) {
				
				oprot.WriteFieldBegin("referenceNo");
				oprot.WriteString(structs.GetReferenceNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizCode() != null) {
				
				oprot.WriteFieldBegin("bizCode");
				oprot.WriteString(structs.GetBizCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizMsg() != null) {
				
				oprot.WriteFieldBegin("bizMsg");
				oprot.WriteString(structs.GetBizMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SortingInfoResponseItem bean){
			
			
		}
		
	}
	
}