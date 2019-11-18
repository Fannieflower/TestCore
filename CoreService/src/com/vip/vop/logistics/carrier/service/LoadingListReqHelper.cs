using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class LoadingListReqHelper : TBeanSerializer<LoadingListReq>
	{
		
		public static LoadingListReqHelper OBJ = new LoadingListReqHelper();
		
		public static LoadingListReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(LoadingListReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("batch_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBatch_no(value);
					}
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("license_plate_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLicense_plate_no(value);
					}
					
					
					
					
					
					if ("packet_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPacket_quantity(value);
					}
					
					
					
					
					
					if ("op_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetOp_time(value);
					}
					
					
					
					
					
					if ("op_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOp_type(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("loading_items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.carrier.service.LoadingItem> value;
						
						value = new List<com.vip.vop.logistics.carrier.service.LoadingItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.carrier.service.LoadingItem elem0;
								
								elem0 = new com.vip.vop.logistics.carrier.service.LoadingItem();
								com.vip.vop.logistics.carrier.service.LoadingItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetLoading_items(value);
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
		
		
		public void Write(LoadingListReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBatch_no() != null) {
				
				oprot.WriteFieldBegin("batch_no");
				oprot.WriteString(structs.GetBatch_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("batch_no can not be null!");
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse can not be null!");
			}
			
			
			if(structs.GetLicense_plate_no() != null) {
				
				oprot.WriteFieldBegin("license_plate_no");
				oprot.WriteString(structs.GetLicense_plate_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("license_plate_no can not be null!");
			}
			
			
			if(structs.GetPacket_quantity() != null) {
				
				oprot.WriteFieldBegin("packet_quantity");
				oprot.WriteI32((int)structs.GetPacket_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("packet_quantity can not be null!");
			}
			
			
			if(structs.GetOp_time() != null) {
				
				oprot.WriteFieldBegin("op_time");
				oprot.WriteI64((long)structs.GetOp_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("op_time can not be null!");
			}
			
			
			if(structs.GetOp_type() != null) {
				
				oprot.WriteFieldBegin("op_type");
				oprot.WriteI32((int)structs.GetOp_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("op_type can not be null!");
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page can not be null!");
			}
			
			
			if(structs.GetLoading_items() != null) {
				
				oprot.WriteFieldBegin("loading_items");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.carrier.service.LoadingItem _item0 in structs.GetLoading_items()){
					
					
					com.vip.vop.logistics.carrier.service.LoadingItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(LoadingListReq bean){
			
			
		}
		
	}
	
}